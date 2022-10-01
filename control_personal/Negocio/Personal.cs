using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace control_personal.Negocio
{
    internal class Personal
    {
        //Attributes
        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string ApP { get; set; }
        public string ApM { get; set; }
        public string Cargo { get; set; }
        public string CI { get; set; }
        public string Numero { get; set; }
        public string Telefono { get; set; }
        public string Pass { get; set; }
        public string Libreta { get; set; } = string.Empty;
        public string FechaNac { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string Vigencia { get; set; }


        public string Message { get; set; }

        public string Lapso { get; set; }

        //Methods
        public bool Verifica() {
            bool isValid = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");

                //-------Verificar datos de ingreso
                
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) Usuario FROM Personal " +
                                                "WHERE CI=@ci AND Pass=@pass", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ci", CI);
                cmd.Parameters.AddWithValue("@pass", Pass);

                con.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                //Procesar info obtenida
                string uniqueUser = string.Empty;

                while (sqlDataReader.Read()) { 
                    uniqueUser = sqlDataReader["Usuario"].ToString();
                }

                sqlDataReader.Close();

                //Obtener rol
                if (uniqueUser == "1") {
                    cmd = new SqlCommand("SELECT Cargo FROM Personal " +
                                         "WHERE CI=@ci AND Pass=@pass", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ci", CI);
                    cmd.Parameters.AddWithValue("@pass", Pass);

                    sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Cargo = sqlDataReader["Cargo"].ToString();
                    }

                    sqlDataReader.Close();

                    isValid = true;
                }

                con.Close();
            }
            catch (SqlException)
            {
                Message = "Ocurrio un error en la base de datos";
            }

            return isValid;
        }

        public bool GetPersonal(ref DataTable info) {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Personal", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                info.Load(sdr);

                con.Close();
                sdr.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la base de datos";
            }

            return exito;        
        }

        public bool GetPersonalHelperInfo(ref DataTable info) {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT IdPersonal, ApellidoP, ApellidoM, Nombre, Cargo, CI, Numero, Libreta, Genero FROM Personal " +
                                                "WHERE Vigencia='1'", con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                info.Load(sdr);

                con.Close();
                sdr.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la base de datos";
            }


            return exito;
        }


        public bool InsertPersonal() { 
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Personal VALUES " +
                                                "(@Nombre, @ApellidoP, @ApellidoM, @Cargo, @CI, @Numero, @Tel, @Pass, @Libreta, @FechaNac, @Genero, @Vigencia)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", ApP);
                cmd.Parameters.AddWithValue("@ApellidoM", ApM);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@CI", CI);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Tel", Telefono);
                cmd.Parameters.AddWithValue("@Pass", Pass);
                cmd.Parameters.AddWithValue("@Libreta", Libreta);
                cmd.Parameters.AddWithValue("@FechaNac", FechaNac);
                cmd.Parameters.AddWithValue("@Genero", Genero);
                cmd.Parameters.AddWithValue("@Vigencia", Vigencia);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la insercion, verifique que el CI no este repetido";
            }
            
            return exito;
        }

        public bool EditPersonal() {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Personal SET " +
                        "Nombre = @Nombre, " +
                        "ApellidoP = @ApellidoP, " +
                        "ApellidoM = @ApellidoM, " +
                        "Cargo = @Cargo, " +
                        "CI = @CI, " +
                        "Numero = @Numero, " +
                        "Tel = @Tel, " +
                        "Pass = @Pass, " +
                        "Libreta = @Libreta, " +
                        "FechaNac = @FechaNac, " +
                        "Genero = @Genero," +
                        "Vigencia = @Vigencia " +
                    "WHERE IdPersonal = @IdPersonal", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", ApP);
                cmd.Parameters.AddWithValue("@ApellidoM", ApM);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@CI", CI);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Tel", Telefono);
                cmd.Parameters.AddWithValue("@Pass", Pass);
                cmd.Parameters.AddWithValue("@Libreta", Libreta);
                cmd.Parameters.AddWithValue("@FechaNac", FechaNac);
                cmd.Parameters.AddWithValue("@Genero", Genero);
                cmd.Parameters.AddWithValue("@Vigencia", Vigencia);

                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la edicion, verifique que el CI no este repetido";
            }



            return exito;
        }
    }
}
