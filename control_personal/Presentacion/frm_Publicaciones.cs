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
    public partial class frm_Publicaciones : Form
    {
        Publicacion publicacion = new Publicacion();
        Personal per = new Personal();

        //Propiedades
        private string Cargo { get; set; }

        public frm_Publicaciones(string pCargo)
        {
            Cargo = pCargo;
            InitializeComponent();
        }

        private void frm_Publicaciones_Load(object sender, EventArgs e)
        {
            if (Cargo == "Docente") { 
                lbl_fechaPublicacion.Visible = false;
                lbl_idPersonal.Visible = false;
                lbl_idPublicacion.Visible = false; 
                lbl_institucion.Visible = false;
                lbl_tipo.Visible = false;
                lbl_titulo.Visible = false;

                txt_idPersonal.Visible = false;
                txt_idPublicacion.Visible = false;
                txt_institucion.Visible = false;
                txt_tipo.Visible = false;
                txt_titulo.Visible = false;

                dtp_fechaPublicacion.Visible = false;

                btn_crear.Visible = false;
                btn_editar.Visible = false;
                btn_limpiar.Visible = false;
            }

            //Mostrar info de publicaciones
            DataTable defecto = new DataTable();
            publicacion.GetPublicacion(ref defecto);
            dataGridView1.DataSource = defecto;

            //Mostrar info de personal como ayuda
            DataTable personalHelper = new DataTable();

            per.GetPersonalHelperInfo(ref personalHelper);
            dataGridView2.DataSource = personalHelper;

            //Limitar fecha
            dtp_fechaPublicacion.MaxDate = DateTime.Now;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_idPersonal.Text == string.Empty || txt_institucion.Text == string.Empty ||
                txt_tipo.Text == string.Empty || txt_titulo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //Asignar valores a objeto
                publicacion.Titulo = txt_titulo.Text;
                publicacion.Tipo = txt_tipo.Text;

                publicacion.FechaPublicacion = dtp_fechaPublicacion.Value.Date.ToString("yyyy-MM-dd");

                publicacion.Institucion = txt_institucion.Text;

                //Subir a la base de datos
                try
                {
                    publicacion.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (publicacion.InsertPublicacion()) {
                        DataTable creado = new DataTable();

                        publicacion.GetPublicacion(ref creado);
                        dataGridView1.DataSource = creado;

                        MessageBox.Show("Insercion exitosa", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(publicacion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(publicacion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_idPersonal.Text == string.Empty || txt_institucion.Text == string.Empty ||
                txt_tipo.Text == string.Empty || txt_titulo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar valores a objeto
                publicacion.Titulo = txt_titulo.Text;
                publicacion.Tipo = txt_tipo.Text;

                publicacion.FechaPublicacion = dtp_fechaPublicacion.Value.Date.ToString("yyyy-MM-dd");

                publicacion.Institucion = txt_institucion.Text;

                //Subir a la base de datos
                try
                {
                    publicacion.IdPublicacion = int.Parse(txt_idPublicacion.Text);
                    publicacion.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (publicacion.EditPublicacion())
                    {
                        DataTable editado = new DataTable();

                        publicacion.GetPublicacion(ref editado);
                        dataGridView1.DataSource = editado;

                        MessageBox.Show("Edicion exitosa", "Edicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(publicacion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(publicacion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                txt_idPublicacion.Text = dgvRow.Cells[0].Value.ToString();
                txt_idPersonal.Text = dgvRow.Cells[1].Value.ToString();
                txt_titulo.Text = dgvRow.Cells[2].Value.ToString();
                txt_tipo.Text = dgvRow.Cells[3].Value.ToString();
                
                dtp_fechaPublicacion.Value = DateTime.Parse(dgvRow.Cells[4].Value.ToString());
                
                txt_institucion.Text = dgvRow.Cells[5].Value.ToString();

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

        //Procedimientos
        public void ClearBoxes() {
            txt_idPersonal.Text = string.Empty;
            txt_idPublicacion.Text = string.Empty;
            txt_institucion.Text = string.Empty;
            txt_tipo.Text = string.Empty;
            txt_titulo.Text = string.Empty;

            dtp_fechaPublicacion.Value = DateTime.Now.AddDays(-1);
        }

    }
}
