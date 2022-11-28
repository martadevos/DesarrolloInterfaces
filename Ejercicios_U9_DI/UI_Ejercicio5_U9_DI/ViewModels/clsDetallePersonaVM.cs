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
    internal class clsDetallePersonaVM
    {
        #region Atributos
        private clsPersona persona;
        #endregion

        #region Propiedades
        public clsPersona Persona { get { return persona; } }
        #endregion

        #region Constructores
        public clsDetallePersonaVM(object persona)
        {
            this.persona = (clsPersona) persona;
        }
        #endregion
    }
}
