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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //verificar entradas
            if (txt_usuario.Text == string.Empty || txt_contraseña.Text == string.Empty)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearText();
            }
            else
            {
                //Verificar usuario
                string userName = txt_usuario.Text;
                string password = txt_contraseña.Text;

                Personal usu = new Personal()
                {
                    CI = userName,
                    Pass = password
                };

                try
                {
                    if (usu.Verifica())
                    {
                        menu ingreso = new menu(usu.Cargo);
                        ClearText();
                        ingreso.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Revise los datos ingresado e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearText();
                    }
                }
                catch { 
                    MessageBox.Show($"Error: {usu.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //-----------PROCEDIMIENTOS
        public void ClearText() {
            txt_contraseña.Text = string.Empty;
            txt_usuario.Text = string.Empty;
        }

    }

}
