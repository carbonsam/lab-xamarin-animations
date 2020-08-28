using System.ComponentModel;
using Xamarin.Forms;
using Animations.ViewModels;

namespace Animations.Views
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