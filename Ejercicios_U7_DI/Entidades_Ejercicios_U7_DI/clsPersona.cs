using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ejercicios_U7_DI
{
    public class clsPersona
    {
        #region Atributos
        private string nombre;
        private string apellidos;
        #endregion

        #region Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        #endregion

        #region Constructores
        public clsPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public clsPersona()
        {
        }
        #endregion
    }
}
