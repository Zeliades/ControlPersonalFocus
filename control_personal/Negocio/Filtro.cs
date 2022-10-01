using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace control_personal.Negocio
{
    internal class Filtro
    {
        //Properties
        public Empresa EmpresaFil { get; set; } = new Empresa();
        public Idioma IdiomaFil { get; set; } = new Idioma();
        public Personal PersonalFil { get; set; } = new Personal();
        public Publicacion PublicacionFil { get; set; } = new Publicacion();
        public Titulo TituloFil { get; set; } = new Titulo();

        public string Message { get; set; }

        //Methods
        public bool Filtrar(ref DataTable info) {
            bool exito = false;

            try
            {
                string query = "SELECT DISTINCT Personal.ApellidoP, Personal.ApellidoM, Personal.Nombre, " +
                                      "Personal.CI, Personal.Genero, Personal.Numero, Personal.Libreta " +
                               "FROM Personal ";

                //---------UNIR TABLAS SEGUN CRITERIOS

                //UNIR informacion de Empresas

                if (EmpresaFil.Cargo != string.Empty)
                {
                    query += "INNER JOIN Empresas ON Personal.IdPersonal=Empresas.IdPersonal ";
                }

                //UNIR informcion de Idiomas
                if (IdiomaFil.Idio != string.Empty || IdiomaFil.Nivel != string.Empty)
                {
                    query += "INNER JOIN Idiomas ON Personal.IdPersonal=Idiomas.IdPersonal ";
                }

                //UNIR informacion de Publicaciones
                if (PublicacionFil.Tipo != string.Empty || PublicacionFil.Institucion != string.Empty || PublicacionFil.Lapso != "Ninguno")
                { 
                    query += "INNER JOIN Publicaciones ON Personal.IdPersonal=Publicaciones.IdPersonal ";
                }

                //UNIR informacion de Titulos
                if (TituloFil.Grado != string.Empty || TituloFil.NombreTitulo != string.Empty || TituloFil.Lapso != "Ninguno" ||
                    TituloFil.Caso != string.Empty)
                { 
                    query += "INNER JOIN Titulos ON Personal.IdPersonal=Titulos.IdPersonal ";
                }

                query += "WHERE Personal.Vigencia = '1' ";

                //FILTRAR informacion de Empresas

                if (EmpresaFil.Cargo != string.Empty) {
                    query += $"AND Empresas.Cargo = '{EmpresaFil.Cargo}' ";    
                }

                //Colocar informacion de Idiomas
                
                if (IdiomaFil.Idio != string.Empty) {
                    query += $"AND Idiomas.Idioma = '{IdiomaFil.Idio}' ";
                }

                if (IdiomaFil.Nivel != "Ninguno" && IdiomaFil.Nivel != string.Empty) {
                    query += $"AND Idiomas.Nivel = '{IdiomaFil.Nivel}' ";
                }

                //Colocar informacion de Publicaciones

                if (PublicacionFil.Tipo != string.Empty) {
                    query += $"AND Publicaciones.Tipo = '{PublicacionFil.Tipo}' ";
                }

                if (PublicacionFil.Institucion != string.Empty) { 
                    query += $"AND Publicaciones.Institucion = '{PublicacionFil.Institucion}' ";
                }

                if (PublicacionFil.FechaPublicacion != string.Empty && PublicacionFil.Lapso == "Antes") {
                    query += $"AND Publicaciones.FechaPublicacion < '{PublicacionFil.FechaPublicacion}' ";
                }

                if (PublicacionFil.FechaPublicacion != string.Empty && PublicacionFil.Lapso == "Despues") {
                    query += $"AND Publicaciones.FechaPublicacion > '{PublicacionFil.FechaPublicacion}' ";
                }

                //Colocar informacion de Titulos

                if (TituloFil.Grado != string.Empty) {
                    query += $"AND Titulos.Grado = '{TituloFil.Grado}' ";
                }

                if (TituloFil.NombreTitulo != string.Empty) {
                    query += $"AND Titulos.NombreTitulo = '{TituloFil.NombreTitulo}' ";
                }

                if (TituloFil.FechaEmision != string.Empty && TituloFil.Lapso == "Antes") {
                    query += $"AND Titulos.FechaEmision < '{TituloFil.FechaEmision}' ";
                }

                if (TituloFil.FechaEmision != string.Empty && TituloFil.Lapso == "Despues") {
                    query += $"AND Titulos.FechaEmision > '{TituloFil.FechaEmision}' ";
                }

                if (TituloFil.Caso != string.Empty) {
                    query += $"AND Titulos.Caso = '{TituloFil.Caso}' ";
                }

                //Colocar informacion de Personal

                if (PersonalFil.FechaNac != string.Empty && PersonalFil.Lapso == "Antes") {
                    query += $"AND Personal.FechaNac < '{PersonalFil.FechaNac}' ";
                }

                if (PersonalFil.FechaNac != string.Empty && PersonalFil.Lapso == "Despues") {
                    query += $"AND Personal.FechaNac > '{PersonalFil.FechaNac}' ";
                }

                if (PersonalFil.Genero != "Ninguno" && PersonalFil.Genero != string.Empty) {
                    query += $"AND Personal.Genero = '{PersonalFil.Genero}' ";
                }

                if (PersonalFil.Libreta != "No contar" && PersonalFil.Libreta != string.Empty) {
                    query += $"AND Personal.Libreta = '{PersonalFil.Libreta}' ";
                }

                //EJECUCION DE LA CONSULTA

                //Message = $"Consulta hecha: {query}\n";

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-INDAPET;Initial Catalog=BDFocus;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                info.Load(sdr);

                sdr.Close();
                con.Close();

                exito = true;
            }
            catch (Exception)
            {
                Message = "Error en la base de datos, reinicie la aplicacion";
            }



            return exito;
        }


    }
}
