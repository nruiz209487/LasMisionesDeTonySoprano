using ENT;

namespace LasMisionesDeTonySoprano.Models
{
    public class MainPageVM
    {

        private List<Mision> _listadoDeMisiones;
        private Mision _misionSeleccionada;
        private List<Candidato> _listadoDeCandidatosPorMision;
        public List<Mision> ListadoDeMisiones
        {
            get { return BL.ReglasDeEmpresa.ObtenerListadoDeMisiones(); }
        }

        public List<Candidato> ListadoDeCandidatosPorMision
        {
            get { return BL.ReglasDeEmpresa.ObtenerCandidatosPorMision(_misionSeleccionada.Dificultad); }
        }

        public Mision MisionSeleccionada
        {
            get { return _misionSeleccionada; }
            set { _misionSeleccionada = value; }


        }

    }
}
