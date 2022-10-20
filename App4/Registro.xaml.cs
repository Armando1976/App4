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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double seguimiento1=Convert.ToDouble(txtParcial1.Text);
            double examen1 = Convert.ToDouble(txtExamen1.Text);
            double final1 = (seguimiento1 * 0.3)+(examen1*0.2);
            string f1;
            f1 = Convert.ToString(final1);
            txtfinal1.Text = f1;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            double seguimiento2 = Convert.ToDouble(txtParcial2.Text);
            double examen2 = Convert.ToDouble(txtExamen2.Text);
            double final2 = (seguimiento2 * 0.3) + (examen2 * 0.2);
            string f2;
            f2 = Convert.ToString(final2);
            txtFinal2.Text = f2;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            double final = Convert.ToDouble(txtfinal1.Text)+Convert.ToDouble(txtFinal2.Text);
            string f;
            f = Convert.ToString(final);
            txtfinal.Text = f;
        }
    }
}