using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Ejercicio5_U9_DI.Models.DAL;
using UI_Ejercicio5_U9_DI.Models.Entidades;

namespace UI_Ejercicio5_U9_DI.ViewModels
{
    internal class clsListaPersonasVM
    {
        #region Atributos
        private ObservableCollection<clsPersona> personas;
        #endregion

        #region Propiedades
        public ObservableCollection<clsPersona> Personas { get { return personas; } }
        #endregion

        #region Constructores
        public clsListaPersonasVM()
        {
            this.personas = clsListadoPersonasDAL.listadoCompletoPersonas();
        }
        #endregion
    }
}
