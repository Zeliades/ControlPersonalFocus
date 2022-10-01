using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace control_personal.Negocio
{
    internal class Idioma
    {
        //Attributes
        public int IdIdioma { get; set; }
        public int IdPersonal { get; set; }
        public string Idio { get; set; } = string.Empty;
        public string Nivel { get; set; } = string.Empty;

        public string Message { get; set; }

        //Methods
        private bool VerificaIdioma() { 
            bool isValid = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) Lang FROM Idiomas " +
                                                "WHERE IdPersonal=@IdPersonal AND Idioma=@Idio", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Idio", Idio);

                con.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                //Procesar info obtenida
                string uniqueLang = string.Empty;

                while (sqlDataReader.Read()) {
                    uniqueLang = sqlDataReader["Lang"].ToString();
                }

                sqlDataReader.Close();
                con.Close();

                //Idioma ya existe
                if (uniqueLang == "1")
                {
                    Message = "El personal ya habla el idioma que se intento ingresar";
                    return isValid;
                }
                else {
                    isValid = true;
                    return isValid;
                }
            }
            catch (SqlException)
            {
                Message = "Error en la base de datos, reinicie el programa";
            }

            return isValid;
        }

        public bool GetIdioma(ref DataTable info) {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Idiomas", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                info.Load(sdr);

                con.Close();
                sdr.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la base de datos, reinicie el programa";
            }

            return exito;
        }

        public bool InsertIdioma() { 
            bool exito = false;

            try
            {
                if (!VerificaIdioma()) {
                    return exito;
                }

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Idiomas VALUES " +
                                                "(@IdPersonal, @Idioma, @Nivel)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Idioma", Idio);
                cmd.Parameters.AddWithValue("@Nivel", Nivel);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la insercion (revise el id del docente)";
            }

            return exito;
        }

        public bool EditIdioma() {
            bool exito = false;

            try
            {
                if (!VerificaIdioma()) {
                    return exito;
                }

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Idiomas SET " +
                        "IdPersonal = @IdPersonal, " +
                        "Idioma = @Idioma, " +
                        "Nivel = @Nivel " +
                    "WHERE IdIdioma = @IdIdioma", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Idioma", Idio);
                cmd.Parameters.AddWithValue("@Nivel", Nivel);
                
                cmd.Parameters.AddWithValue("@IdIdioma", IdIdioma);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la edicion (revise el id del docente)";
            }

            return exito;
        }
    }
}
