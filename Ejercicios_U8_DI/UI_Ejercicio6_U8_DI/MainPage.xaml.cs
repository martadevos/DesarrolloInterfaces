namespace UI_Ejercicio6_U8_DI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dtpckFechaNac.MaximumDate = DateTime.Now;
        }

        private async void imgbtGuardarPersona_Clicked(object sender, EventArgs e)
        {
            lblNombreVacio.IsVisible = txtNombre.Text == "";
            lblApellidoVacio.IsVisible = txtApellido.Text == "";
            lblRealizadoCorrectamente.Text = "Se ha guardado correctamente";
            lblRealizadoCorrectamente.IsVisible = !lblNombreVacio.IsVisible && !lblApellidoVacio.IsVisible;
        }

        private async void imgbtnBorrarPersona_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("¿Estás seguro de que quieres borrar?", "Si aceptas, no podrás recuperar esta información", "Continuar", "Cancelar");
        
            if (resp)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                dtpckFechaNac.Date = DateTime.Today;
                lblRealizadoCorrectamente.Text = "Se ha borrado correctamente";
                lblRealizadoCorrectamente.IsVisible = true;
            }
        }

        private void imgbtnAñadirPersona_Clicked(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpckFechaNac.Date = DateTime.Today;
        }
    }
}