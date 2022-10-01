using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace control_personal.Negocio
{
    internal class Publicacion
    {
        //Attributes
        public int IdPublicacion { get; set; }
        public int IdPersonal { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string FechaPublicacion { get; set; } = string.Empty;
        public string Institucion { get; set; } = string.Empty;

        public string Message { get; set; }

        public string Lapso { get; set; } = "Ninguno";

        //Methods
        private bool VerificaPublicacion() {
            bool isValid = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) Exist FROM Publicaciones " +
                                                "WHERE IdPersonal=@IdPersonal AND Titulo=@Titulo AND FechaPublicacion=@FechaPublicacion", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Titulo", Titulo);
                cmd.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);

                con.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                //Procesar info obtenida
                string uniquePubl = string.Empty;

                while (sqlDataReader.Read()) {
                    uniquePubl = sqlDataReader["Exist"].ToString();
                }

                //Publicacion ya existe
                if (int.Parse(uniquePubl) > 0)
                {
                    Message = "El personal ya presenta una publicacion similar";
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

        public bool GetPublicacion(ref DataTable info) {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Publicaciones", con);

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

        public bool InsertPublicacion()
        {
            bool exito = false;

            try
            {
                if (!VerificaPublicacion()) {
                    return exito;
                }

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Publicaciones VALUES " +
                                                "(@IdPersonal, @Titulo, @Tipo, @FechaPublicacion, @Institucion)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Titulo", Titulo);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);
                cmd.Parameters.AddWithValue("@Institucion", Institucion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;

            }
            catch (SqlException)
            {
                Message = "Error en la insercion, revise el id del docente y la fecha";
            }

            return exito;
        }

        public bool EditPublicacion()
        {
            bool exito = false;

            try
            {
                
                if (!VerificaPublicacion()) {
                    return exito;
                }
                

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Publicaciones SET " +
                        "IdPersonal = @IdPersonal, " +
                        "Titulo = @Titulo, " +
                        "Tipo = @Tipo, " +
                        "FechaPublicacion = @FechaPublicacion, " +
                        "Institucion = @Institucion " +
                    "WHERE IdPublicacion = @IdPublicacion", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Titulo", Titulo);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);
                cmd.Parameters.AddWithValue("@Institucion", Institucion);

                cmd.Parameters.AddWithValue("@IdPublicacion", IdPublicacion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la edicion (revise id del docente y la fecha)";
            }


            return exito;
        }
    }
}
