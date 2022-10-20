using App4.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App4.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}