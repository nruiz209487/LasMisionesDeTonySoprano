using ENT;

namespace BL
{
    public class ReglasDeEmpresa
    {

        /// <summary>
        /// Obtiene el listado de misiones completo llama a la DAL
        /// </summary>
        /// <returns>Listado del objeto Candidato</returns>
        public static List<Mision> ObtenerListadoDeMisiones()
        {
            return DAL.Service.ObtenerListadoDeMisionesBD();
        }

        /// <summary>
        /// Obtiene un candiato por Id
        /// </summary>
        /// <param name="idCandidato"></param>
        /// <returns> objeto Candidato </returns>
        public static Candidato ObtenerCandidatoPorId(int idCandidato)
        {
            return DAL.Service.ObtenerCandidatoPorId(idCandidato);
        }

        /// <summary>
        /// Recibe como parametro la dificultad  y llama a la funcion en la DAL asigna los valores edadMinima,edadMaxima y pais de origen dependiendo de la dificultad
        /// </summary>
        /// <param name="dificultadMision"></param>
        /// <returns>Listado de candidatos filtrado</returns>
        public static List<Candidato> ObtenerCandidatosPorMision(int dificultadMision)
        {
            int edadMinima = 0;
            int edadMaxima = 150;
            string paisDeOigen;

            switch (dificultadMision)
            {

                case 1:
                    paisDeOigen = "USA";
                    break;
                case 2:
                    paisDeOigen = "USA";
                    break;
                case 3:
                    paisDeOigen = "USA";
                    edadMinima = 40;
                    break;
                case 4:
                    paisDeOigen = "Italia";
                    edadMaxima = 45;
                    break;
                case 5:
                    paisDeOigen = "Italia";
                    edadMinima = 45;
                    edadMaxima = 65;
                    break;
                default:
                    paisDeOigen = "USA";
                    break;


            }
            return DAL.Service.ObtenerCandidatosPorMisionDB(edadMinima, edadMaxima, paisDeOigen);
        }


    }
}
