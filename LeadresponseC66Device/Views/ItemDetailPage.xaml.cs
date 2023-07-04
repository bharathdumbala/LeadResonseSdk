using LeadresponseC66Device.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LeadresponseC66Device.Views
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