using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Mision
    {

        #region propiedades  
        private int _id;
        private string _nombre = "";
        private int _dificultad;
        #endregion
        #region getters y setters 
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0 && value != _id)
                {
                    _id = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value != _nombre)
                {
                    _nombre = value;
                }
            }
        }

        public int Dificultad
        {
            get
            {
                return _dificultad;
            }
            set
            {
                if (value > 0 && value != _dificultad)
                {
                    _dificultad = value;
                }
            }
        }
        #endregion
        #region constructores
        public Mision() { }

        public Mision(int id, string name, int dificulty)
        {
            if (id > 0) { _id = id; }
            if (!string.IsNullOrEmpty(name)) { _nombre = name; }
            if (dificulty > 0) { _dificultad = dificulty; }

        }
        #endregion
    }
}
