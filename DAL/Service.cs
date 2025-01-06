using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Service
    {

        private static SqlConnection getConexion()
        {
            SqlConnection miConexion = new SqlConnection();

            try
            {
                miConexion.ConnectionString = "server=nruiz-nervion.database.windows.net;database=nruizDB ;uid=usuario;pwd=LaCampana123;trustServerCertificate = true;";
                miConexion.Open();

            }
            catch (Exception)
            {
                throw;
            }

            return miConexion;
        }

        /// <summary>
        /// Llama a la DB y obtiene un listado de misiones
        /// </summary>
        /// <returns>Listado del objeto Mision </returns>
        public static List<Mision> ObtenerListadoDeMisionesBD()
        {
            List<Mision> list = new List<Mision>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            Mision misionObj;

            try
            {
                conexion = getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {

                    miComando.CommandText = "SELECT * FROM Misiones";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();


                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {

                            misionObj = new Mision();
                            misionObj.Id = (int)miLector["Id"];
                            misionObj.Nombre = (string)miLector["Nombre"];
                            misionObj.Dificultad = (int)miLector["Dificultad"];


                            list.Add(misionObj);
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return list;
        }


        /// <summary>
        /// Llama a la base de datos para obtener un listado de Candidatos flitrado por la dificultad de la mision 
        /// </summary>
        /// <param name="dificultadMision"></param>
        /// <returns>Listado de candidatos flitrados</returns>
        public static List<Candidato> ObtenerCandidatosPorMisionDB(int edadMinima, int edadMaxima, string paisDeOigen)
        {
            List<Candidato> list = new List<Candidato>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                conexion = getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@edadMinima", System.Data.SqlDbType.Int).Value = edadMinima;
                    miComando.Parameters.Add("@edadMaxima", System.Data.SqlDbType.Int).Value = edadMaxima;
                    miComando.Parameters.Add("@paisDeOigen", System.Data.SqlDbType.VarChar).Value = paisDeOigen;
                    miComando.CommandText = "SELECT * FROM Candidatos WHERE Pais = @paisDeOigen AND YEAR(CURRENT_TIMESTAMP) - Year(FechaNacimiento) > @edadMinima AND YEAR(CURRENT_TIMESTAMP) - Year(FechaNacimiento) < @edadMaxima";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {
                            Candidato candidatoObj = new Candidato();

                            candidatoObj.Id = (int)miLector["Id"];
                            candidatoObj.Nombre = (string)miLector["Nombre"];
                            candidatoObj.Apellidos = (string)miLector["Apellidos"];
                            candidatoObj.Direccion = (string)miLector["Direccion"];
                            candidatoObj.Pais = (string)miLector["Pais"];
                            candidatoObj.Telefono = (int)miLector["Telefono"];
                            candidatoObj.FechaNacimiento = DateOnly.FromDateTime((DateTime)miLector["FechaNacimiento"]);
                            candidatoObj.Precio = (int)miLector["Precio"];

                            list.Add(candidatoObj);
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return list;
        }

        /// <summary>
        /// Llama a la bd y obtiwnw un candidato por id
        /// </summary>
        /// <param name="idCandidato"></param>
        /// <returns>objeto tipo candidato </returns>
        public static Candidato ObtenerCandidatoPorId(int idCandidato)
        {
            Candidato candidatoObj = new Candidato();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;

            try
            {
                conexion = getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = idCandidato;
                    miComando.CommandText = "SELECT * FROM Candidatos WHERE Id = @id";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {


                            candidatoObj.Id = (int)miLector["Id"];
                            candidatoObj.Nombre = (string)miLector["Nombre"];
                            candidatoObj.Apellidos = (string)miLector["Apellidos"];
                            candidatoObj.Direccion = (string)miLector["Direccion"];
                            candidatoObj.Pais = (string)miLector["Pais"];
                            candidatoObj.Telefono = (int)miLector["Telefono"];
                            candidatoObj.FechaNacimiento = DateOnly.FromDateTime((DateTime)miLector["FechaNacimiento"]);
                            candidatoObj.Precio = (int)miLector["Precio"];
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Close();

            }

            return candidatoObj;
        }


    }
}
