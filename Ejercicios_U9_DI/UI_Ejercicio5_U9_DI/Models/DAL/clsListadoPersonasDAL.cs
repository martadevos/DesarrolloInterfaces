using Kotlin.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Ejercicio5_U9_DI.Models.Entidades;

namespace UI_Ejercicio5_U9_DI.Models.DAL
{
    internal class clsListadoPersonasDAL
    {
        public static ObservableCollection<clsPersona> listadoCompletoPersonas()
        {
            ObservableCollection<clsPersona> listaPersonas = new ObservableCollection<clsPersona>();
            listaPersonas.Add(new clsPersona("Marta", "Devós", "09/12/2003", "direccion1", "telefono1"));
            listaPersonas.Add(new clsPersona("Juan José", "Muñoz", "06/07/2000", "direccion2", "telefono2"));
            listaPersonas.Add(new clsPersona("Rafael David", "Devós", "06/01/1974", "direccion3", "telefono3"));
            listaPersonas.Add(new clsPersona("Marta", "Devós", "21/10/1972", "direccion4", "telefono4"));
            listaPersonas.Add(new clsPersona("Marta", "Garcia", "09/12/2003", "direccion5", "telefono5"));
            listaPersonas.Add(new clsPersona("Berta", "Devós", "06/01/2005", "direccion6", "telefono6"));
            listaPersonas.Add(new clsPersona("Fernando", "Devós", "07/05/2099", "direccion7", "telefono7"));
            listaPersonas.Add(new clsPersona("Agustin", "Devós", "07/07/2003", "direccion8", "telefono8"));
            return listaPersonas;
        }
    }
}
