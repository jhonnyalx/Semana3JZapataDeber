using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3JZapataDeber
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        public Operaciones(string usuario, string password)
        {
            InitializeComponent()   ;
            txtUsuario.Text = usuario + " " + password;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            var total = (Convert.ToDouble(txtNotaExamen2.Text) * 0.2 + Convert.ToDouble(txtNotaSeguimiento.Text) * 0.3) + (Convert.ToDouble(txtNotaExamen.Text) * 0.2 + Convert.ToDouble(txtNotaSeguimiento.Text) * 0.3);
            grid.Children.Add(new Label
            {
                Text = (Convert.ToDouble(txtNotaSeguimiento.Text) * 0.3).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 0, 1);
            grid.Children.Add(new Label
            {
                Text = (Convert.ToDouble(txtNotaSeguimiento2.Text) * 0.3).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 0, 2);
            grid.Children.Add(new Label
            {
                Text = (Convert.ToDouble(txtNotaExamen.Text) * 0.2).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 1, 1);
            grid.Children.Add(new Label
            {
                Text = (Convert.ToDouble(txtNotaExamen2.Text) * 0.2).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 1, 2);
            grid.Children.Add(new Label
            {
                Text = (Convert.ToDouble(txtNotaExamen.Text) * 0.2 + Convert.ToDouble(txtNotaSeguimiento.Text) * 0.3).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 2, 1);
            grid.Children.Add(new Label
            {
                Text = (Convert.ToDouble(txtNotaExamen2.Text) * 0.2 + Convert.ToDouble(txtNotaSeguimiento.Text) * 0.3).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 2, 2);
            grid.Children.Add(new Label
            {
                Text = (total).ToString(),
                HeightRequest = 0,
                HorizontalOptions = LayoutOptions.Center
            }, 2, 3);

            if (total >= 7)
            {
                DisplayAlert("Verificacion de calificaciones", "Aprobado :" + total, "OK");
            }
            else
            {
                DisplayAlert("Verificacion de calificaciones", "Reprobado :" + total, "OK");
            }


        }


        private void habilitarCalculo()
        {
            if ((txtNotaSeguimiento.Text) != null && (txtNotaSeguimiento2.Text) != null && (txtNotaExamen.Text) != null && (txtNotaExamen2.Text) != null)
            {
                if ((txtNotaSeguimiento.Text).Length > 0 && (txtNotaSeguimiento2.Text).Length > 0 && (txtNotaExamen.Text).Length > 0 && (txtNotaExamen2.Text).Length > 0)
                {
                    if ((Convert.ToDouble(txtNotaSeguimiento.Text) > 0 && Convert.ToDouble(txtNotaSeguimiento.Text) <= 10) &&
                        (Convert.ToDouble(txtNotaSeguimiento2.Text) > 0 && Convert.ToDouble(txtNotaSeguimiento2.Text) <= 10) &&
                        (Convert.ToDouble(txtNotaExamen.Text) > 0 && Convert.ToDouble(txtNotaExamen.Text) <= 10) &&
                        (Convert.ToDouble(txtNotaExamen2.Text) > 0 && Convert.ToDouble(txtNotaExamen2.Text) <= 10))
                    {
                        btnCalcular.IsVisible = true;
                    }
                    else
                    {
                        btnCalcular.IsVisible = false;
                    }
                }
            }

        }

        private void txtNotaExamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            habilitarCalculo();
        }

        private void txtNotaSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {
            habilitarCalculo();
        }

        private void txtNotaExamen_TextChanged(object sender, TextChangedEventArgs e)
        {
            habilitarCalculo();
        }

        private void txtNotaSeguimiento_TextChanged(object sender, TextChangedEventArgs e)
        {
            habilitarCalculo();
        }
    }
}