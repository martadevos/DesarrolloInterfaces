using Entidades_Ejercicios1Y2_U10_DI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Ejercicios1y2_U10_DI
{
    public class clsListadoPersonas
    {
        public static ObservableCollection<clsPersona> listadoCompletoPersonas()
        {
            ObservableCollection<clsPersona> listaPersonas = new ObservableCollection<clsPersona>();
            listaPersonas.Add(new clsPersona("Marta", "Devós", "09/12/2003"));
            listaPersonas.Add(new clsPersona("Rafael David", "Devós", "06/01/1974"));
            listaPersonas.Add(new clsPersona("Agustin", "Devós", "21/10/1972"));
            listaPersonas.Add(new clsPersona("Marta", "Garcia", "09/12/2003"));
            listaPersonas.Add(new clsPersona("Berta", "Devós", "06/01/2005"));
            listaPersonas.Add(new clsPersona("Fernando", "Devós", "07/05/2099"));
            listaPersonas.Add(new clsPersona("Agustin", "Devós", "07/07/2003"));
            return listaPersonas;
        }
    }
}
