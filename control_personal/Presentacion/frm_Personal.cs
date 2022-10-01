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
    public partial class frm_Personal : Form
    {
        Personal personal = new Personal();

        //Propiedades
        private string Cargo { get; set; }

        public frm_Personal(string pCargo)
        {
            Cargo = pCargo;            
            InitializeComponent();
        }

        private void frm_Personal_Load(object sender, EventArgs e)
        {
            //Quitar visibilidad segun cargo
            if (Cargo == "Secretaria" || Cargo == "Docente") {
                lblapellidoM.Visible = false;
                lblapellidoP.Visible = false;
                lblcargo.Visible = false;
                lblcI.Visible = false;
                lblfechaNac.Visible = false;
                lblgenero.Visible = false;
                lblidPersonal.Visible = false;
                lbllibreta.Visible = false;
                lblnombre.Visible = false;
                lblnumero.Visible = false;
                lblpass.Visible = false;
                lbltel.Visible = false;
                lbl_vigencia.Visible = false;

                txt_apellidoM.Visible = false;
                txt_apellidoP.Visible = false;
                txt_cargo.Visible = false;
                txt_cI.Visible = false;
                dtp_fechaNac.Visible = false;
                txt_genero.Visible = false;
                txt_idPersonal.Visible = false;
                txt_libreta.Visible = false;
                txt_nombre.Visible = false;
                txt_numero.Visible = false;
                txt_pass.Visible = false;
                txt_tel.Visible = false;
                txt_vigencia.Visible = false;
                
                btn_crear.Visible = false;
                btn_editar.Visible = false;
                btn_limpiar.Visible = false;
            }
            
            //Mostrar informacion
            DataTable defecto = new DataTable();
            personal.GetPersonal(ref defecto);
            dataGridView1.DataSource = defecto;

            //Limite de fecha a escoger
            dtp_fechaNac.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //Verificar entradas completas
            if (txt_apellidoM.Text == "" || txt_apellidoP.Text == "" || txt_cargo.Text == "" || txt_cI.Text == "" ||
                txt_genero.Text == "" || txt_libreta.Text == "" || txt_nombre.Text == "" || txt_vigencia.Text == "" ||
                txt_numero.Text == "" || txt_pass.Text == "" || txt_tel.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar valores a objeto
                personal.Nombre = txt_nombre.Text;
                personal.ApP = txt_apellidoP.Text;
                personal.ApM = txt_apellidoM.Text;
                personal.Cargo = txt_cargo.Text;
                personal.CI = txt_cI.Text;
                personal.Numero = txt_numero.Text;
                personal.Telefono = txt_tel.Text;
                personal.Pass = txt_pass.Text;
                personal.Libreta = txt_libreta.Text;
                personal.FechaNac = dtp_fechaNac.Value.Date.ToString("yyyy-MM-dd");
                personal.Genero = txt_genero.Text;
                personal.Vigencia = txt_vigencia.Text;

                //Subir a base de datos
                try
                {
                    if (personal.InsertPersonal()) {
                        DataTable creado = new DataTable();

                        personal.GetPersonal(ref creado);
                        dataGridView1.DataSource = creado;

                        MessageBox.Show("Insercion exitosa", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(personal.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                catch (Exception)
                {
                    MessageBox.Show(personal.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Verificar entradas completas
            if (txt_apellidoM.Text == "" || txt_apellidoP.Text == "" || txt_cargo.Text == "" || txt_cI.Text == "" ||
                txt_genero.Text == "" || txt_libreta.Text == "" || txt_nombre.Text == "" || txt_vigencia.Text == "" ||
                txt_numero.Text == "" || txt_pass.Text == "" || txt_tel.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asignar valores a objetos
                personal.Nombre = txt_nombre.Text;
                personal.ApP = txt_apellidoP.Text;
                personal.ApM = txt_apellidoM.Text;
                personal.Cargo = txt_cargo.Text;
                personal.CI = txt_cI.Text;
                personal.Numero = txt_numero.Text;
                personal.Telefono = txt_tel.Text;
                personal.Pass = txt_pass.Text;
                personal.Libreta = txt_libreta.Text;
                personal.FechaNac = dtp_fechaNac.Value.Date.ToString("yyyy-MM-dd");
                personal.Genero = txt_genero.Text;
                personal.Vigencia = txt_vigencia.Text;

                //Subir a base de datos
                try
                {
                    personal.IdPersonal = int.Parse(txt_idPersonal.Text);

                    if (personal.EditPersonal())
                    {
                        DataTable editado = new DataTable();

                        personal.GetPersonal(ref editado);
                        dataGridView1.DataSource = editado;

                        MessageBox.Show("Edicion exitosa", "Edicion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBoxes();
                    }
                    else
                        MessageBox.Show(personal.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception)
                {
                    MessageBox.Show(personal.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txt_idPersonal.Text = dgvRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgvRow.Cells[1].Value.ToString();
                txt_apellidoP.Text = dgvRow.Cells[2].Value.ToString();
                txt_apellidoM.Text = dgvRow.Cells[3].Value.ToString();
                txt_cargo.Text = dgvRow.Cells[4].Value.ToString();
                txt_cI.Text = dgvRow.Cells[5].Value.ToString();
                txt_numero.Text = dgvRow.Cells[6].Value.ToString();
                txt_tel.Text = dgvRow.Cells[7].Value.ToString();
                txt_pass.Text = dgvRow.Cells[8].Value.ToString();
                txt_libreta.Text = dgvRow.Cells[9].Value.ToString();
                dtp_fechaNac.Value = DateTime.Parse(dgvRow.Cells[10].Value.ToString());
                txt_genero.Text = dgvRow.Cells[11].Value.ToString();
                txt_vigencia.Text = dgvRow.Cells[12].Value.ToString();
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

        //Procedimientos
        public void ClearBoxes() {
            txt_apellidoM.Text = string.Empty;
            txt_apellidoP.Text = string.Empty;
            txt_cargo.Text = string.Empty;
            txt_cI.Text = string.Empty;
            dtp_fechaNac.Value = DateTime.Now.AddYears(-18).AddDays(-1);
            txt_genero.Text = string.Empty;
            txt_idPersonal.Text = string.Empty;
            txt_libreta.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_numero.Text = string.Empty;
            txt_pass.Text = string.Empty;
            txt_tel.Text = string.Empty;
            txt_vigencia.Text= string.Empty;
        }

    }
}
