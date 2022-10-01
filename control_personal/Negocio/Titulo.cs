using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace control_personal.Negocio
{
    internal class Titulo
    {
        //Attributes
        public int IdTitulo { get; set; }
        public int IdPersonal { get; set; }
        public string Grado { get; set; } = string.Empty;
        public string NombreTitulo { get; set; } = string.Empty;
        public string FechaEmision { get; set; } = string.Empty;
        public string Caso { get; set; } = string.Empty;
        public string Pais { get; set; }
        public string Institucion { get; set; }
        public string CodigoTitulo { get; set; }

        public string Message { get; set; }

        public string Lapso { get; set; } = "Ninguno";

        //Methods
        public bool GetTitulo(ref DataTable info) {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Titulos", con);

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

        public bool InsertTitulo()
        {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Titulos VALUES " +
                                                "(@IdPersonal, @Grado, @NombreTitulo, @FechaEmision, @Caso, @Pais, @Institucion, @CodigoTitulo)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Grado", Grado);
                cmd.Parameters.AddWithValue("@NombreTitulo", NombreTitulo);
                cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision);
                cmd.Parameters.AddWithValue("@Caso", Caso);
                cmd.Parameters.AddWithValue("@Pais", Pais);
                cmd.Parameters.AddWithValue("@Institucion", Institucion);
                cmd.Parameters.AddWithValue("@CodigoTitulo", CodigoTitulo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;

            }
            catch (SqlException)
            {
                Message = "Error en la insercion (revise el id del docente, que el codigo de titulo no se repita y la fecha)";
            }

            return exito;
        }

        public bool EditTitulo()
        {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Titulos SET " +
                        "IdPersonal = @IdPersonal, " +
                        "Grado = @Grado, " +
                        "NombreTitulo = @NombreTitulo, " +
                        "FechaEmision = @FechaEmision, " +
                        "Caso = @Caso, " +
                        "Pais = @Pais, " +
                        "Institucion = @Institucion, " +
                        "CodigoTitulo = @CodigoTitulo " +
                    "WHERE IdTitulo = @IdTitulo", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@Grado", Grado);
                cmd.Parameters.AddWithValue("@NombreTitulo", NombreTitulo);
                cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision);
                cmd.Parameters.AddWithValue("@Caso", Caso);
                cmd.Parameters.AddWithValue("@Pais", Pais);
                cmd.Parameters.AddWithValue("@Institucion", Institucion);
                cmd.Parameters.AddWithValue("@CodigoTitulo", CodigoTitulo);

                cmd.Parameters.AddWithValue("@IdTitulo", IdTitulo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la edicion (revise id del docente, que el codigo de titulo no se repita y la fecha)";
            }

            return exito;
        }
    }
}
