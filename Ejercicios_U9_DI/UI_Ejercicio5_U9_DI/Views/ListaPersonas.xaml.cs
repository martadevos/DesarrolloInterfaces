using UI_Ejercicio5_U9_DI.Models.DAL;
using UI_Ejercicio5_U9_DI.ViewModels;

namespace UI_Ejercicio5_U9_DI.Views;

public partial class ListaPersonas : ContentPage
{
	public ListaPersonas()
	{
		InitializeComponent();
    }

	private async void lvPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
        await Navigation.PushAsync(new Views.DetallesPersona { BindingContext = new clsDetallePersonaVM(lvPersonas.SelectedItem) });
    }
}