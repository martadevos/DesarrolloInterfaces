using Entidades_Ejercicios1Y2_U10_DI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Ejercicio1_U10_DI.ViewModels.Utilidades;

namespace UI_Ejercicio1_U10_DI.ViewModels
{
    internal class clsListadopersonasVM : clsVMBase
    {

        #region Atributos

        private ObservableCollection<clsPersona> listadoPersonasCompleto;
        private ObservableCollection<clsPersona> listadoPersonasMostrado;
        private clsPersona personaSeleccionada;
        private string entryBuscarPersona;
        private DelegateCommand eliminarCommand; //Comando Elminar Persona
        private DelegateCommand buscarCommand; //Comando Buscar Persona

        #endregion

        #region Propiedades
        public ObservableCollection<clsPersona> ListadoPersonasMostrado { get { return listadoPersonasMostrado; } }
        
        public string EntryBuscarPersona
        {
            get { return entryBuscarPersona; }
            set
            {
                if (entryBuscarPersona != value)
                {
                    entryBuscarPersona = value;
                    buscarCommand.RaiseCanExecuteChanged();
                }

            }
        }

        public DelegateCommand BuscarCommand
        {
            get
            {
                buscarCommand = new DelegateCommand(BuscarCommand_Execute, BuscarCommand_CanExecute);
                return buscarCommand;
            }
        }

        public clsPersona PersonaSeleccionada
        {
            get 
            { 
                return personaSeleccionada; 
            }
            set 
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                    eliminarCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public DelegateCommand EliminarCommand 
        { 
            get 
            {
                eliminarCommand = new DelegateCommand(EliminarCommand_Execute, EliminarCommand_CanExecute);
                return eliminarCommand; 
            } 
        }

        #endregion

        #region Constructores

        public clsListadopersonasVM()
        {
            listadoPersonasCompleto = new ObservableCollection<clsPersona>(DAL_Ejercicios1y2_U10_DI.clsListadoPersonas.listadoCompletoPersonas());
            listadoPersonasMostrado = new ObservableCollection<clsPersona>(listadoPersonasCompleto);
        }

        #endregion

        #region Commands

        /// <summary>
        /// Muestra una alerta para confirmar que se quiere borrar la persona; si la respuesta es sí, 
        /// la elimina de los listados de personas completo y mostrar y notifica para mostrar el actualizado
        /// </summary>
        private async void EliminarCommand_Execute()
        {
            bool answer = await Application.Current.MainPage.DisplayAlert("¿Eliminar persona?", "Una vez eliminada no podrá ser recuperada", "Si", "No");
            if (answer)
            {
                listadoPersonasCompleto.Remove(PersonaSeleccionada);
                listadoPersonasMostrado.Remove(PersonaSeleccionada);
                personaSeleccionada = null;
                NotifyPropertyChanged(nameof(ListadoPersonasMostrado));
                eliminarCommand.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Comprueba que haya una persona seleccionada y si la hay devuelve true, si no la hay, devuelve false
        /// </summary>
        /// <returns> Booleano que indica si se habilita o no el botón </returns>
        private bool EliminarCommand_CanExecute()
        {

            bool sePuedeBorrar = true;

            //Si no hay una persona seleccionada no se puede borrar

            if (personaSeleccionada == null)

            {

                sePuedeBorrar = false;

            }

            return sePuedeBorrar;

        }

        /// <summary>
        /// Recorre el listado completo de personas y, si coincide el nombre o apellido de una de ellas con lo escrito en el entry,
        /// la añade a la lista mostrada; una vez acaba de recorrer la lista completa, notifica a la lista mostrada para que se actualice
        /// </summary>
        private void BuscarCommand_Execute()
        {
            listadoPersonasMostrado.Clear();
            foreach (clsPersona persona in listadoPersonasCompleto)
            {
                if (persona.Nombre.ToLowerInvariant().StartsWith(entryBuscarPersona.ToLowerInvariant()) || persona.Apellidos.ToLowerInvariant().StartsWith(entryBuscarPersona.ToLowerInvariant()))
                {
                    listadoPersonasMostrado.Add(persona);
                }
            }
            NotifyPropertyChanged(nameof(ListadoPersonasMostrado));
        }

        /// <summary>
        /// Comprueba que el entry no esté vacío y si lo está devuelve false y muestra el listado completo, si no está vacío devuelve true
        /// </summary>
        /// <returns> Booleano que indica si se habilita o no el botón </returns>
        private bool BuscarCommand_CanExecute()
        {

            bool sePuedeBuscar = true;

            //Si el entry de buscar persona esta vacio, no se activa el botón

            if (string.IsNullOrEmpty(entryBuscarPersona))

            {
                listadoPersonasMostrado = new ObservableCollection<clsPersona>(listadoPersonasCompleto);
                NotifyPropertyChanged(nameof(ListadoPersonasMostrado));
                sePuedeBuscar = false;

            }

            return sePuedeBuscar;

        }

        #endregion

    }
}
