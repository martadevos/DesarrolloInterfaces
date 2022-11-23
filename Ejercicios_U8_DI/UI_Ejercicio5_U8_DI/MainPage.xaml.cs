using DAL_Ejercicio5_U8_DI;
using Entidades_Ejercicio5_U8_DI;
using System.Collections.ObjectModel;

namespace UI_Ejercicio5_U8_DI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<clsPersona> listadoPersonas = clsListadoPersonasDAL.getListadoCompletoPersonas();

            lvPersonas.ItemsSource = listadoPersonas;
        }
    }
}