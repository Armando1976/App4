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

        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "Armando";
            string password = "12345";
            string tusuario = txtUsuario.Text;
            string tpassword = txtClave.Text;
            if (usuario == tusuario & password == tpassword)
            {
                DisplayAlert("Alerta", "Usuario Correcto", "Cerrar");
                Navigation.PushAsync(new Registro());
            }
            else
            {
                DisplayAlert("Alerta", "Usuario Incorrecto", "Cerrar");
            }       
        }
    }
}