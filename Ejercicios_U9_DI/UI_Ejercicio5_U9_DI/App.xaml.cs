namespace UI_Ejercicio5_U9_DI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListaPersonas());
        }
    }
}