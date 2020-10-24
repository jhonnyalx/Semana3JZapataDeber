using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3JZapataDeber
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnLogear_Clicked(object sender, EventArgs e)
        {
            var usuario = "estudiante2020";
            var password = "uisrael2020";
            if (txtUsuario.Text == usuario && txtPassword.Text == password)
            {
                await Navigation.PushAsync(new Operaciones(txtUsuario.Text,txtPassword.Text)); ;
            }
            else 
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                DisplayAlert("Login", "Usuario o contraseña invalido", "Ok");
            }
        }
    }
}
