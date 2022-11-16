using Entidades_Ejercicio1_U5_DI;

namespace UI_Ejercicio1_U5_DI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de click del btnSaludar. Pide el apellido con un prompt y muestra un saludo con el nombre y apellidos de la persona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaludarBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                await DisplayAlert("ERROR", $"Debes ingresar un nombre", "OK");
            }
            else
            {
                clsPersona persona = new clsPersona();
                persona.Nombre = txtNombre.Text;
                persona.Apellidos = await DisplayPromptAsync("Introduce tus apellidos: ", "");
                if (string.IsNullOrEmpty(persona.Apellidos))
                {
                    await DisplayAlert("ERROR", $"Debes ingresar un apellido", "OK");
                }
                else
                {
                    await DisplayAlert("", $"Hola {persona.Nombre} {persona.Apellidos}! :)", "OK");
                }
            }
        }
    }
}