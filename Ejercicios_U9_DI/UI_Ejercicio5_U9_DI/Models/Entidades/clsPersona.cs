using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Ejercicio5_U9_DI.Models.Entidades
{
    public class clsPersona
    {
        #region Atributos
        private string nombre;
        private string apellidos;
        private string fechaNac;
        private string fotoURL;
        private string direccion;
        private string telefono;
        #endregion

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string FechaNac { get { return fechaNac; } set { fechaNac = value; } }
        public string FotoURL { get { return fotoURL; } set { fotoURL = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        #endregion

        #region Constructores
        public clsPersona() { }

        public clsPersona(string nombre, string apellidos, string fechaNac, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.fotoURL = "https://thispersondoesnotexist.com/image";
            this.direccion = direccion;
            this.telefono = telefono;
        }
        #endregion
    }
}
