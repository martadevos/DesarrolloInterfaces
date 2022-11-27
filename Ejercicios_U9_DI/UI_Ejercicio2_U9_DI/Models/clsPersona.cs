using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Ejercicio2_U9_DI.Models
{
    public class clsPersona : INotifyPropertyChanged
    {
        #region Atributos
        private string nombre;
        private string apellidos;
        private string fechaNac;
        #endregion

        #region Propiedades
        public string Nombre 
        { 
            get 
            { 
                return nombre; 
            } 
            set 
            { 
                nombre = value; 
                onPropertyChanged("Nombre"); 
            } 
        }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string FechaNac { get { return fechaNac; } set { fechaNac = value; } }
        #endregion

        #region Constructores
        public clsPersona()
        {
            this.nombre = "Marta";
            this.apellidos = "Devós Garcia";
            this.fechaNac = "09/12/2003";
        }
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
