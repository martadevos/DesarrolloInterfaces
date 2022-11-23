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
            bool camposRellenos = txtNombre.Text != "" && txtApellido.Text != "";
            if (!camposRellenos)
            {
                lblNombreVacio.IsVisible = true;
                lblApellidoVacio.IsVisible = true;
            }
            else
            {
                lblNombreVacio.IsVisible = false;
                lblApellidoVacio.IsVisible = false;
                await DisplayAlert("Guardado correctamente", txtNombre.Text + " " + txtApellido.Text + " se ha guardado correctamente", "OK");
            }
        }

        private async void imgbtnBorrarPersona_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("¿Estás seguro de que quieres borrar?", "Si aceptas, no podrás recuperar esta información", "Continuar", "Cancelar");
        
            if (resp)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                dtpckFechaNac.Date = DateTime.Today;
                await DisplayAlert("Borrado correctamente", "La persona se ha borrado correctamente", "OK");
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