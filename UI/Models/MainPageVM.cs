using System;
using System.Collections.Generic;
using ENT;
using LasMisionesDeTonySoprano.Models;

namespace LasMisionesDeTonySoprano.Models
{
    public class MainPageVM
    {

        private int _dificultadMisionSeleccionada;
        private List<Candidato> _listadoDeCandidatosPorMision = new List<Candidato>();

        /// <summary>
        /// Listado De misiones que se obtiene llamando directamente a la BL 
        /// </summary>
        public List<Mision> ListadoDeMisiones
        {
            get { return BL.ReglasDeEmpresa.ObtenerListadoDeMisiones(); }
        }


        /// <summary>
        /// Cuuando la difucultad se actualiza (no es igual a 0) se llaama a la db y se actaliza el listado que en un porincipio esaba vacio 
        /// </summary>
        public List<Candidato> ListadoDeCandidatosPorMision
        {
            get
            {
                if (_dificultadMisionSeleccionada != 0) { _listadoDeCandidatosPorMision = BL.ReglasDeEmpresa.ObtenerCandidatosPorMision(_dificultadMisionSeleccionada); }
                return _listadoDeCandidatosPorMision;
            }
        }

        /// <summary>
        /// Popiedad que interactua con la vista me parece mas facil slecionar solo la dificultad que el objeto completo
        /// </summary>
        public int DificultadMisionSeleccionada
        {
            get { return _dificultadMisionSeleccionada; }
            set
            {
                if (_dificultadMisionSeleccionada != value)
                {
                    _dificultadMisionSeleccionada = value;
                }
            }
        }
    }
}
