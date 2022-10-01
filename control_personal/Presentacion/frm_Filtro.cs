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
    public partial class frm_Filtro : Form
    {

        public frm_Filtro()
        {
            InitializeComponent();
        }

        private void frm_Filtro_Load(object sender, EventArgs e)
        {
            //Default PERSONAL
            cmb_personalEdad.Text = "Ninguno";
            cmb_personalGenero.Text = "Ninguno";
            cmb_personalLibreta.Text = "No contar";

            //Default IDIOMAS
            cmb_idiomaNivel.Text = "Ninguno";

            //Default PUBLICACIONES
            cmb_publicacionFecha.Text = "Ninguno";

            //Default TITULOS
            cmb_tituloFecha.Text = "Ninguno";


            // CONFIGURACION DE FECHA
            dtp_publicacionFecha.MaxDate = DateTime.Now;
            dtp_tituloFecha.MaxDate = DateTime.Now;
            dtp_personalEdad.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Filtro funca = new Filtro();

            // FILTRADO GENERAL

            if (!grb_personal.Enabled && !grb_empresas.Enabled && !grb_idiomas.Enabled &&
                !grb_publicaciones.Enabled && !grb_titulos.Enabled)
            { 
                MessageBox.Show("Habilite al menos un criterio a filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // FILTRADO PERSONAL

            if (grb_personal.Enabled)
            {
                if (cmb_personalEdad.Text == "Ninguno" && cmb_personalGenero.Text == "Ninguno" && cmb_personalLibreta.Text == "No contar")
                {
                    MessageBox.Show("PERSONAL: ingrese al menos un criterio a filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;                
                }
                else
                {
                    // INFORMACION DE PERSONAL
                    funca.PersonalFil.Lapso = cmb_personalEdad.Text;
                    funca.PersonalFil.FechaNac = dtp_personalEdad.Value.Date.ToString("yyyy-MM-dd");
                    funca.PersonalFil.Genero = cmb_personalGenero.Text;
                    funca.PersonalFil.Libreta = cmb_personalLibreta.Text;
                }
            }

            // FILTRADO EMPRESAS
            
            if (grb_empresas.Enabled)
            {
                if (txt_empresaCargo.Text == string.Empty)
                {
                    MessageBox.Show("EMPRESAS: ingrese un criterio a filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                { 
                    // INFORMACION DE EMPRESAS
                    funca.EmpresaFil.Cargo = txt_empresaCargo.Text;
                }
            }

            // FILTRADO IDIOMAS
            if (grb_idiomas.Enabled)
            {
                if (txt_idioma.Text == string.Empty && cmb_idiomaNivel.Text == "Ninguno")
                {
                    MessageBox.Show("IDIOMAS: ingrese al menos un criterio a filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                { 
                    // INFORMACION DE IDIOMAS
                    funca.IdiomaFil.Idio = txt_idioma.Text;
                    funca.IdiomaFil.Nivel = cmb_idiomaNivel.Text;
                }
            }

            // FILTRADO PUBLICACIONES
            if (grb_publicaciones.Enabled)
            {
                if (txt_publicacionTipo.Text == string.Empty && txt_publicionInstitucion.Text == string.Empty &&
                    cmb_publicacionFecha.Text == "Ninguno")
                {
                    MessageBox.Show("PUBLICACIONES: ingrese al menos un criterio a filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                { 
                    //INFORMACION DE PUBLICACIONES
                    funca.PublicacionFil.Tipo = txt_publicacionTipo.Text;
                    funca.PublicacionFil.Institucion = txt_publicionInstitucion.Text;
                    funca.PublicacionFil.Lapso = cmb_publicacionFecha.Text;
                    funca.PublicacionFil.FechaPublicacion = dtp_publicacionFecha.Value.Date.ToString("yyyy-MM-dd");
                }
            }

            //FILTRADO TITULOS
            if (grb_titulos.Enabled)
            {
                if (txt_tituloGrado.Text == string.Empty && txt_tituloCaso.Text == string.Empty && txt_tituloNombre.Text == string.Empty &&
                   cmb_tituloFecha.Text == "Ninguno")
                {
                    MessageBox.Show("TITULOS: ingrese al menos un criterio a filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                { 
                    //INFORMACION DE TITULOS
                    funca.TituloFil.Grado = txt_tituloGrado.Text;
                    funca.TituloFil.Caso = txt_tituloCaso.Text;
                    funca.TituloFil.NombreTitulo = txt_tituloNombre.Text;
                    funca.TituloFil.Lapso = cmb_tituloFecha.Text;
                    funca.TituloFil.FechaEmision = dtp_tituloFecha.Value.Date.ToString("yyyy-MM-dd");
                }
            }
            

            //Consulta a la base de datos
            try
            {
                DataTable filtro = new DataTable();
                if (funca.Filtrar(ref filtro)) { 
                    dataGridView1.DataSource = filtro;

                    MessageBox.Show("Filtrado exitoso", "Filtrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(funca.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show(funca.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_habilitaPersonal_Click(object sender, EventArgs e)
        {
            bool acti = (grb_personal.Enabled) ? grb_personal.Enabled = false : grb_personal.Enabled = true;
        }

        private void btn_habilitaEmpresa_Click(object sender, EventArgs e)
        {
            bool acti = (grb_empresas.Enabled) ? grb_empresas.Enabled = false : grb_empresas.Enabled = true;
        }

        private void btn_habilitaIdioma_Click(object sender, EventArgs e)
        {
            bool acti = (grb_idiomas.Enabled) ? grb_idiomas.Enabled = false : grb_idiomas.Enabled = true;
        }

        private void btn_habilitaPublicacion_Click(object sender, EventArgs e)
        {
            bool acti = (grb_publicaciones.Enabled) ? grb_publicaciones.Enabled = false : grb_publicaciones.Enabled = true;
        }

        private void btn_habilitaTitulo_Click(object sender, EventArgs e)
        {
            bool acti = (grb_titulos.Enabled) ? grb_titulos.Enabled = false : grb_titulos.Enabled = true;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
