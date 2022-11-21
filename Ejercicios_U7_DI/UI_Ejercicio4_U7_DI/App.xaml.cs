using UI_Ejercicio4_U7_DI.Views.MenuFlyout;

namespace UI_Ejercicio4_U7_DI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageNavigation();
        }
    }
}