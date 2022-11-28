using Entidades_Ejercicio4_U9_DI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Ejercicio4_U9_DI.ViewModels
{
    internal class clsMainPageVM : clsPersona, INotifyPropertyChanged
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
                if (value.Contains('n'))
                {
                    base.Apellidos = "";
                    onPropertyChanged("Apellidos");
                }
            }
        }
        public new string Apellidos
        {
            get
            {
                return base.Apellidos;
            }
            set
            {
                base.Apellidos = value;

                if (value.Contains('n'))
                {
                    base.Nombre = "";
                    onPropertyChanged("Nombre");
                }
            }
        }
        #endregion

        #region Constructores
        public clsMainPageVM() { }
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