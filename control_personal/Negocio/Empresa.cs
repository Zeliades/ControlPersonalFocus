using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace control_personal.Negocio
{
    internal class Empresa
    {
        //Attributes
        public int IdEmpresa { get; set; }
        public int IdPersonal { get; set; }
        public string NombreEmp { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Cargo { get; set; } = string.Empty;

        public string Message { get; set; }

        //Methods
        private bool VerificaEmpresa() { 
            bool isValid = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) Exist FROM Empresas " +
                                                "WHERE IdPersonal=@IdPersonal AND " +
                                                "FechaInicio BETWEEN @FechaIni AND @FechaFin OR " +
                                                "FechaFinal BETWEEN @FechaIni AND @FechaFin OR " +
                                                "(@FechaIni <= FechaInicio AND @FechaFin >= FechaFinal)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@FechaIni", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", FechaFinal);

                con.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                //Procesar info obtenida
                string uniqueJob = string.Empty;

                while (sqlDataReader.Read()) {
                    uniqueJob = sqlDataReader["Exist"].ToString();
                }

                //Ya trabaja en este periodo
                if (int.Parse(uniqueJob) > 0)
                {
                    Message = "El personal ya trabaja en este lapso de tiempo";
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


        public bool GetEmpresa(ref DataTable info) {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Empresas", con);

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

        public bool InsertEmpresa()
        {
            bool exito = false;

            try
            {
                if (Convert.ToDateTime(FechaInicio) >= Convert.ToDateTime(FechaFinal)) {
                    Message = "La fecha de inicio no puede ser mayor o igual a la final";
                    return exito;
                }

                if (!VerificaEmpresa()) {
                    return exito;
                }

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Empresas VALUES " +
                                                "(@IdPersonal, @NombreEmp, @FechaInicio, @FechaFinal, @Cargo)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@NombreEmp", NombreEmp);
                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", FechaFinal);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la insercion, revise el id del docente y las fechas";
            }

            return exito;
        }

        public bool EditEmpresa()
        {
            bool exito = false;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Empresas SET " +
                        "IdPersonal = @IdPersonal, " +
                        "NombreEmp = @NombreEmp, " +
                        "FechaInicio = @FechaInicio, " +
                        "FechaFinal = @FechaFinal, " +
                        "Cargo = @Cargo " +
                    "WHERE IdEmpresa = @IdEmpresa", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@IdPersonal", IdPersonal);
                cmd.Parameters.AddWithValue("@NombreEmp", NombreEmp);
                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", FechaFinal);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);

                cmd.Parameters.AddWithValue("@IdEmpresa", IdEmpresa);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                exito = true;
            }
            catch (SqlException)
            {
                Message = "Error en la edicion (revise id del docente y las fechas)";
            }

            return exito;
        }


    }
}
