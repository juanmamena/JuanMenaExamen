using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JuanMenaExamen
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(System.Object sender, System.EventArgs e)
        {
            if (txtUsuario.Text.ToLower() == "estudiante2021" && txtPassword.Text == "uisrael2021")
            {
                await Navigation.PushAsync(new RegistroPage(txtUsuario.Text));
            }
            else
            {
                await DisplayAlert("MENSAJE", "Usuario o Clave incorrecto", "ACEPTAR");
            }
        }
    }
}
