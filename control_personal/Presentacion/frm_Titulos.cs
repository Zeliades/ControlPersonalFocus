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
    public partial class frm_Titulos : Form
    {
        Titulo titulo = new Titulo();
        Personal per = new Personal();

        //Propiedades
        private string Cargo { get; set; }

        public frm_Titulos(string pCargo)
        {
            Cargo = pCargo;
            InitializeComponent();
        }

        private void frm_Titulos_Load(object sender, EventArgs e)
        {
            if (Cargo == "Docente") {
                lbl_caso.Visible = false;
                lbl_fechaEmision.Visible = false;
                lbl_grado.Visible = false;
                lbl_idPersonal.Visible = false;
                lbl_idTitulo.Visible = false;
                lbl_nombreTitulo.Visible = false;
                lbl_pais.Visible = false;
                lbl_institucion.Visible = false;
                lbl_codigo.Visible = false;

                txt_caso.Visible = false;
                txt_grado.Visible = false;
                txt_idPersonal.Visible = false;
                txt_idTitulo.Visible = false;
                txt_nombreTitulo.Visible = false;
                txt_pais.Visible = false;
                txt_institucion.Visible = false;
                txt_codigoTitulo.Visible = false;

                dtp_fechaEmision.Visible = false;

                btn_crear.Visible = false;
                btn_editar.Visible = false;
                btn_limpiar.Visible = false;
            }

            //Mostrar info de titulos existentes
            DataTable defecto = new DataTable();

            titulo.GetTitulo(ref defecto);
            dataGridView1.DataSource = defecto;

            //Mostrar info de personal como ayuda
            DataTable personalHelper = new DataTable();
            
            per.GetPersonalHelperInfo(ref personalHelper);
            dataGridView2.DataSource = personalHelper;

            //Limite para fecha
            dtp_fechaEmision.MaxDate = DateTime.Now;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_caso.Text == string.Empty || txt_grado.Text == string.Empty || txt_pais.Text == string.Empty || txt_codigoTitulo.Text == string.Empty ||
                txt_idPersonal.Text == string.Empty || txt_nombreTitulo.Text == string.Empty || txt_institucion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                //Asignar valores a objeto
                titulo.Grado = txt_grado.Text;
                titulo.NombreTitulo = txt_nombreTitulo.Text;

                titulo.FechaEmision = dtp_fechaEmision.Value.Date.ToString("yyyy-MM-dd");
            
                titulo.Caso = txt_caso.Text;
                titulo.Pais = txt_pais.Text;
                titulo.Institucion = txt_institucion.Text;
                titulo.CodigoTitulo = txt_codigoTitulo.Text;

                //Subir a la base de datos
                try
                {
                    titulo.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (titulo.InsertTitulo()) {
                        DataTable creado = new DataTable();

                        titulo.GetTitulo(ref creado);
                        dataGridView1.DataSource = creado;

                        MessageBox.Show("Insercion exitosa", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(titulo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(titulo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_caso.Text == string.Empty || txt_grado.Text == string.Empty || txt_pais.Text == string.Empty || txt_codigoTitulo.Text == string.Empty ||
                txt_idPersonal.Text == string.Empty || txt_nombreTitulo.Text == string.Empty || txt_institucion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar valores a objeto
                titulo.Grado = txt_grado.Text;
                titulo.NombreTitulo = txt_nombreTitulo.Text;

                titulo.FechaEmision = dtp_fechaEmision.Value.Date.ToString("yyyy-MM-dd");

                titulo.Caso = txt_caso.Text;
                titulo.Pais = txt_pais.Text;
                titulo.Institucion = txt_institucion.Text;
                titulo.CodigoTitulo = txt_codigoTitulo.Text;

                //Subir a la base de datos
                try
                {
                    titulo.IdTitulo = int.Parse(txt_idTitulo.Text);
                    titulo.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (titulo.EditTitulo()) {
                        DataTable editado = new DataTable();

                        titulo.GetTitulo(ref editado);
                        dataGridView1.DataSource = editado;

                        MessageBox.Show("Edicion exitosa", "Edicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(titulo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(titulo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txt_idTitulo.Text = dgvRow.Cells[0].Value.ToString();
                txt_idPersonal.Text = dgvRow.Cells[1].Value.ToString();
                txt_grado.Text = dgvRow.Cells[2].Value.ToString();
                txt_nombreTitulo.Text = dgvRow.Cells[3].Value.ToString();

                dtp_fechaEmision.Value = DateTime.Parse(dgvRow.Cells[4].Value.ToString());
                
                txt_caso.Text = dgvRow.Cells[5].Value.ToString();
                txt_pais.Text = dgvRow.Cells[6].Value.ToString();
                txt_institucion.Text = dgvRow.Cells[7].Value.ToString();
                txt_codigoTitulo.Text = dgvRow.Cells[8].Value.ToString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
                DataGridViewRow dgvRow = dataGridView2.Rows[e.RowIndex];

                txt_idPersonal.Text = dgvRow.Cells[0].Value.ToString();
            }
        }

        //Procedimientos
        public void ClearBoxes() {
            txt_caso.Text = string.Empty;
            txt_grado.Text = string.Empty;
            txt_idPersonal.Text = string.Empty;
            txt_idTitulo.Text = string.Empty;
            txt_nombreTitulo.Text = string.Empty;
            txt_pais.Text = string.Empty;
            txt_institucion.Text = string.Empty;
            txt_codigoTitulo.Text = string.Empty;

            dtp_fechaEmision.Value = DateTime.Now.AddDays(-1);
        }

    }
}
