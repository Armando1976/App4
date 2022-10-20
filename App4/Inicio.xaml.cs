using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string password = "uisrael2022";
            string tusuario = txtUsuario.Text;
            string tpassword = txtClave.Text;
            if (usuario == tusuario & password == tpassword)
            {
                DisplayAlert("Alerta", "Usuario Correcto", "Cerrar");
                await Navigation.PushAsync(new Registro(txtUsuario.Text, txtClave.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario Incorrecto", "Cerrar");
            }       
        }
    }
}