using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Ejercicio5_U8_DI;

namespace DAL_Ejercicio5_U8_DI
{
    public class clsListadoPersonasDAL
    {
        /// <summary>
    	/// Función que nos devuelve un listado de todas las personas
    	/// </summary>
    	/// <returns>Listado de personas</returns>
    	public List<clsPersona> getListadoCompletoPersonas()
        {
            List<clsPersona> personas = new List<clsPersona>();
            personas.Add(new clsPersona("Marta", "Devós", "09/12/2003"));
            personas.Add(new clsPersona("Juan José", "Muñoz", "06/07/2000"));
            personas.Add(new clsPersona("Rafael David", "Devos", "06/01/1974"));
            personas.Add(new clsPersona("Marta", "Devos", "21/10/1972"));
            personas.Add(new clsPersona("Marta", "Garcia", "09/12/2003"));
            personas.Add(new clsPersona("Berta", "Devos", "06/01/2005"));
            personas.Add(new clsPersona("Fernando", "Devos", "07/05/2099"));
            personas.Add(new clsPersona("Agustin", "Devos", "07/07/2003"));
        }

    }
}
