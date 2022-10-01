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
    public partial class menu : Form
    {
        //Propiedades
        private string Cargo { get; set; }


        public menu(string pCargo)
        {
            Cargo = pCargo;
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //Botones para segun cargo
            if (Cargo == "Secretaria" || Cargo == "Docente") { 
                btn_Personal.Visible = false;
            }
        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {
            frm_Personal ingreso = new frm_Personal(Cargo);
            ingreso.ShowDialog();
        }
        private void btn_Idiomas_Click(object sender, EventArgs e)
        {
            frm_Idiomas ingreso = new frm_Idiomas(Cargo);
            ingreso.ShowDialog();
        }
        private void btn_Empresas_Click(object sender, EventArgs e)
        {
            frm_Empresas ingreso = new frm_Empresas(Cargo);
            ingreso.ShowDialog();
        }

        private void btn_Publicaciones_Click(object sender, EventArgs e)
        {
            frm_Publicaciones ingreso = new frm_Publicaciones(Cargo);
            ingreso.ShowDialog();
        }

        private void btn_Titulos_Click(object sender, EventArgs e)
        {
            frm_Titulos ingreso = new frm_Titulos(Cargo);
            ingreso.ShowDialog();
        }
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            frm_Filtro ingreso = new frm_Filtro();
            ingreso.ShowDialog();
        }

        private void btn_salirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }










        //--------------------PROCEDIMIENTOS

    }
}
