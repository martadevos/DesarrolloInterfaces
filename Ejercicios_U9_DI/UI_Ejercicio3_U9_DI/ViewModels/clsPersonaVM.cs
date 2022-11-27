using Entidades_Ejercicio3_U9_DI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Ejercicio3_U9_DI.ViewModels
{
    internal class clsPersonaVM : clsPersona, INotifyPropertyChanged
    {
        #region Propiedades
        public new string Nombre
        {
            get
            {
                return base.Nombre;
            }
            set
            {
                base.Nombre = value; 
                onPropertyChanged("Nombre");
            }
        }
        #endregion

        #region Constructores
        public clsPersonaVM() {}
        #endregion
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}
