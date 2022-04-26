using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JuanMenaExamen
{
    public partial class ResumenPage : ContentPage
    {
        public ResumenPage(String usuario,String nombre,String valorCuota)
        {
            InitializeComponent();

            lblUser.Text = usuario;
            lblNombre.Text = nombre;
            lblTotal.Text = (Double.Parse(valorCuota) * 3).ToString();

        }
    }
}
