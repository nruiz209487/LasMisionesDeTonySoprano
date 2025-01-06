namespace ENT
{
    public class Candidato
    {

        #region propiedades
        private int _id;
        private string _nombre = "";
        private string _apellidos = "";
        private string _direccion = "";
        private string _pais = "";
        private int _telefono;
        protected DateOnly _fechaNacimiento;
        private int _precio;
        #endregion

        #region getters y setters

        public int Id
        {

            get { return _id; }
            set
            {
                if (_id != value && value > 0)
                {

                    _id = value;
                }

            }
        }
        public string Nombre
        {

            get { return _nombre; }
            set
            {
                if (_nombre != value && !string.IsNullOrEmpty(value))
                {

                    _nombre = value;
                }

            }
        }


        public string Apellidos
        {

            get { return _apellidos; }
            set
            {
                if (_apellidos != value && !string.IsNullOrEmpty(value))
                {

                    _apellidos = value;
                }

            }
        }


        public string Direccion
        {

            get { return _direccion; }
            set
            {
                if (_direccion != value && !string.IsNullOrEmpty(value))
                {

                    _direccion = value;
                }

            }
        }


        public string Pais
        {

            get { return _pais; }
            set
            {
                if (_pais != value && !string.IsNullOrEmpty(value))
                {

                    _pais = value;
                }

            }
        }


        public int Telefono
        {

            get { return _telefono; }
            set
            {
                if (_telefono != value && value >= 111111111 && value <= 999999999)
                {

                    _telefono = value;
                }

            }
        }

        public DateOnly FechaNacimiento
        {

            get { return _fechaNacimiento; }
            set
            {
                if (_fechaNacimiento != value)
                {
                    _fechaNacimiento = value;
                }

            }
        }
        public int Precio
        {

            get { return _precio; }
            set
            {
                if (_precio != value && value > 0)
                {

                    _precio = value;
                }

            }
        }

        #endregion

        #region constructores
        public Candidato()
        {
        }


        public Candidato(int id, string nombre, string apllidos, string direcion, string pais, int teelfono, DateOnly fechaNacimiento, int precio)
        {
            if (id > 0) { _id = id; }
            if (!string.IsNullOrEmpty(nombre)) { _nombre = nombre; }
            if (!string.IsNullOrEmpty(apllidos)) { _apellidos = apllidos; }
            if (!string.IsNullOrEmpty(direcion)) { _direccion = direcion; }
            if (!string.IsNullOrEmpty(pais)) { _pais = pais; }
            if (teelfono >= 111111111 && teelfono <= 999999999) { _telefono = teelfono; }
            _fechaNacimiento = fechaNacimiento;
            if (id > 0) { _precio = precio; }
        }

        #endregion


    }
}
