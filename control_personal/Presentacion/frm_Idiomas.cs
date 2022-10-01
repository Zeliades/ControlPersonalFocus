using control_personal.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_personal
{
    public partial class frm_Idiomas : Form
    {
        Idioma lang = new Idioma();
        Personal per = new Personal();

        //Propiedades
        private string Cargo { get; set; }

        public frm_Idiomas(string pCargo)
        {
            Cargo = pCargo;
            InitializeComponent();
        }

        private void frm_Idiomas_Load(object sender, EventArgs e)
        {
            //Quitar visibilidad segun cargo
            if (Cargo == "Docente") {
                lblidIdioma.Visible = false;
                lblidioma.Visible = false;
                lblidPersonal.Visible = false;
                lblnivel.Visible = false;

                txt_idIdioma.Visible = false;
                txt_idioma.Visible = false;
                txt_idPersonal.Visible = false;
                txt_nivel.Visible = false;

                btn_crear.Visible = false;
                btn_editar.Visible = false;
                btn_limpiar.Visible = false;
            }

            //Mostrar informacion de la BD
            DataTable defecto = new DataTable();
            lang.GetIdioma(ref defecto);
            dataGridView1.DataSource = defecto;

            //Mostrar info de personal como ayuda
            DataTable personalHelper = new DataTable();

            per.GetPersonalHelperInfo(ref personalHelper);
            dataGridView2.DataSource = personalHelper;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_idioma.Text == string.Empty || txt_idPersonal.Text == string.Empty || txt_nivel.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                //asignar valores a objeto
                lang.Idio = txt_idioma.Text;
                lang.IdPersonal = int.Parse(txt_idPersonal.Text);
                lang.Nivel = txt_nivel.Text;

                //subir a base de datos
                try
                {
                    if (lang.InsertIdioma()) { 
                        DataTable creado = new DataTable();

                        lang.GetIdioma(ref creado);
                        dataGridView1.DataSource = creado;

                        MessageBox.Show("Insercion exitosa", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(lang.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(lang.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_idioma.Text == string.Empty || txt_idPersonal.Text == string.Empty || txt_nivel.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //asignar valores a objeto
                lang.Idio = txt_idioma.Text;
                lang.Nivel = txt_nivel.Text;

                //Subir a base de datos
                try
                {
                    lang.IdIdioma = int.Parse(txt_idIdioma.Text);
                    lang.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (lang.EditIdioma())
                    {
                        DataTable editado = new DataTable();

                        lang.GetIdioma(ref editado);
                        dataGridView1.DataSource = editado;

                        MessageBox.Show("Edicion exitosa", "Edicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(lang.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(lang.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txt_idIdioma.Text = dgvRow.Cells[0].Value.ToString();
                txt_idPersonal.Text = dgvRow.Cells[1].Value.ToString();
                txt_idioma.Text = dgvRow.Cells[2].Value.ToString();
                txt_nivel.Text = dgvRow.Cells[3].Value.ToString();

            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView2.Rows[e.RowIndex];

                txt_idPersonal.Text = dgvRow.Cells[0].Value.ToString();
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        //PROCEDIMIENTOS
        public void ClearBoxes() { 
            txt_idIdioma.Text = string.Empty;
            txt_idioma.Text = string.Empty;
            txt_idPersonal.Text = string.Empty;
            txt_nivel.Text = string.Empty;
        }

    }
}
