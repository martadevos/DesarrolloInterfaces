using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicio3_U9_DI
{
    public class clsPersona
    {
        #region Atributos
        private string nombre;
        private string apellidos;
        private string fechaNac;
        #endregion

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
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
    }
}
