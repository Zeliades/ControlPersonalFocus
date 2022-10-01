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
    public partial class frm_Empresas : Form
    {
        Empresa empresa = new Empresa();
        Personal per = new Personal();

        //Propiedades
        private string Cargo { get; set; }

        public frm_Empresas(string pCargo)
        {
            Cargo = pCargo;
            InitializeComponent();
        }

        private void frm_Empresas_Load(object sender, EventArgs e)
        {
            if (Cargo == "Docente") {
                lbl_cargo.Visible = false;
                lbl_fechaFinal.Visible = false;
                lbl_fechaInicio.Visible = false;
                lbl_idEmpresa.Visible = false;
                lbl_idPersonal.Visible = false;
                lbl_nombreEmp.Visible = false;

                txt_cargo.Visible = false;
                txt_idEmpresa.Visible = false;
                txt_idPersonal.Visible = false;
                txt_nombreEmp.Visible = false;

                dtp_fechaFinal.Visible = false;
                dtp_fechaInicio.Visible = false;

                btn_crear.Visible = false;
                btn_editar.Visible = false;
                btn_limpiar.Visible = false;
            }

            //Colocar fechas maximas en dateTimePicker
            dtp_fechaFinal.MaxDate = DateTime.Now;
            dtp_fechaInicio.MaxDate = DateTime.Now;

            //Mostrar info de empresas existentes
            DataTable defecto = new DataTable();
            empresa.GetEmpresa(ref defecto);
            dataGridView1.DataSource = defecto;

            //Mostrar info de personal como ayuda
            DataTable personalHelper = new DataTable();

            per.GetPersonalHelperInfo(ref personalHelper);
            dataGridView2.DataSource = personalHelper;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_cargo.Text == string.Empty || txt_idPersonal.Text == string.Empty || txt_nombreEmp.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar valores a objeto
                empresa.NombreEmp = txt_nombreEmp.Text;
                empresa.FechaInicio = dtp_fechaInicio.Value.Date.ToString("yyyy-MM-dd");
                empresa.FechaFinal = dtp_fechaFinal.Value.Date.ToString("yyyy-MM-dd");
                empresa.Cargo = txt_cargo.Text;

                //Subir a la base de datos
                try
                {
                    empresa.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (empresa.InsertEmpresa()) {
                        DataTable creado = new DataTable();

                        empresa.GetEmpresa(ref creado);
                        dataGridView1.DataSource = creado;

                        MessageBox.Show("Insercion exitosa", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(empresa.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(empresa.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Verificar entradas completas
            if (txt_cargo.Text == string.Empty || txt_idPersonal.Text == string.Empty || txt_nombreEmp.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar valores a objetos
                empresa.NombreEmp = txt_nombreEmp.Text;
                empresa.FechaInicio = dtp_fechaInicio.Value.Date.ToString("yyyy-MM-dd");
                empresa.FechaFinal = dtp_fechaFinal.Value.Date.ToString("yyyy-MM-dd");
                empresa.Cargo = txt_cargo.Text;

                //Subir a la base de datos
                try
                {
                    empresa.IdEmpresa = int.Parse(txt_idEmpresa.Text);
                    empresa.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (empresa.EditEmpresa())
                    {
                        DataTable editado = new DataTable();

                        empresa.GetEmpresa(ref editado);
                        dataGridView1.DataSource = editado;

                        MessageBox.Show("Edicion exitosa", "Edicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(empresa.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception)
                {
                    MessageBox.Show(empresa.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) { 
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txt_idEmpresa.Text = dgvRow.Cells[0].Value.ToString();
                txt_idPersonal.Text = dgvRow.Cells[1].Value.ToString();
                txt_nombreEmp.Text = dgvRow.Cells[2].Value.ToString();

                dtp_fechaInicio.Value = DateTime.Parse(dgvRow.Cells[3].Value.ToString());
                dtp_fechaFinal.Value = DateTime.Parse(dgvRow.Cells[4].Value.ToString());

                txt_cargo.Text = dgvRow.Cells[5].Value.ToString();
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Procedimientos
        public void ClearBoxes() {
            txt_cargo.Text = string.Empty;
            txt_idEmpresa.Text = string.Empty;
            txt_idPersonal.Text = string.Empty;
            txt_nombreEmp.Text = string.Empty;

            dtp_fechaFinal.Value = DateTime.Now.AddDays(-1);
            dtp_fechaInicio.Value = DateTime.Now.AddDays(-1);
        }

    }
}
