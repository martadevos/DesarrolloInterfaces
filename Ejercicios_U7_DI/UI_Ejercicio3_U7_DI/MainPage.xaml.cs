using Entidades_Ejercicios_U7_DI;

namespace UI_Ejercicio3_U7_DI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIrAPaginaTabbed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PaginaTabbed());
        }

        private async void btnIrAPaginaCuatroYCinco_Clicked(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona(txtNombre.Text, txtApellidos.Text);

            if (sender == btnIrAPaginaCuatro)
            {
                await Navigation.PushAsync(new Views.Pagina4(persona));
            }
            else if (sender == btnIrAPaginaCinco)
            {
                await Navigation.PushAsync(new Views.Pagina5 { BindingContext = persona });
            }
        }
    }
}