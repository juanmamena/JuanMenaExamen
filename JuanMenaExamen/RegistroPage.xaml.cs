using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JuanMenaExamen
{
    public partial class RegistroPage : ContentPage
    {
        private static double montoCurso = 1800.00;
        private static double porcentajeCredito = montoCurso * 0.05;

        public RegistroPage(String user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private double calcularPagoMensual(double pagoInicial)
        {
            double valorCuota = 0.0;
            if(pagoInicial> montoCurso)
            {
                DisplayAlert("Error", "Pago inicial no puede superar el monto total del curso que es de " + montoCurso + " dolares", "Aceptar");
            }
            else if (pagoInicial == montoCurso)
            {
                lblPago.Text = "0.0";
            }
            else
            {
                valorCuota=((montoCurso-pagoInicial)/3)+porcentajeCredito;

            }
            return valorCuota;
        }

        void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            lblPago.Text =calcularPagoMensual(Double.Parse(txtMonto.Text)).ToString();
        }

        private async void btnGuardar_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ResumenPage(lblUser.Text,txtNombre.Text,lblPago.Text));
        }
    }
}
