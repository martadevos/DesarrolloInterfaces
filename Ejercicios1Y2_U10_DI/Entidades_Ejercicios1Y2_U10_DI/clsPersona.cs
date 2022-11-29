using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicios1Y2_U10_DI
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
        public clsPersona(string nombre, string apellidos, string fechaNac)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
        }
        #endregion
    }
}
