using ENT;

namespace LasMisionesDeTonySoprano.Models
{
    public class CandidatoConEdad : Candidato
    {
        private int _edad;

        public int Edad
        {
            get { return DateTime.Now.Year - _fechaNacimiento.Year; }
        }

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


