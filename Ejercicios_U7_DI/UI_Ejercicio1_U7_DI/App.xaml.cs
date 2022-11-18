using UI_Ejercicio1_U7_DI.Views;

namespace UI_Ejercicio1_U7_DI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


        MainPage = new PaginaTabbed();

    }
}
