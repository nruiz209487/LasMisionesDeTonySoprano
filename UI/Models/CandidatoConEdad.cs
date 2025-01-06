using ENT;

namespace LasMisionesDeTonySoprano.Models
{
    public class CandidatoConEdad : Candidato
    {

        /// <summary>
        /// Popiedad autoimplementada que devuelve la edad
        /// </summary>
        public int Edad
        {
            get { return DateTime.Now.Year - _fechaNacimiento.Year; }
        }

        /// <summary>
        /// Contrcutor Simplemente se le pasa un candidato ya creado y se transfieren las popiedades
        /// </summary>
        /// <param name="candidato"></param>
        public CandidatoConEdad(Candidato candidato)
        {
            Id = candidato.Id;
            Nombre = candidato.Nombre;
            Apellidos = candidato.Apellidos;
            Direccion = candidato.Direccion;
            FechaNacimiento = candidato.FechaNacimiento;
            Pais = candidato.Pais;
            Telefono = candidato.Telefono;
            Precio = candidato.Precio;
        }
    }
}


