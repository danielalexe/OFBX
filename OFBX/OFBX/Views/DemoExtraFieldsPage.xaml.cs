using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OFBX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoExtraFieldsPage : ContentPage
    {
        public DemoExtraFieldsPage()
        {
            InitializeComponent();
            DemoProgressBar.Animate("SetProgress", (arg) => { DemoProgressBar.Progress = arg; }, 100, 10000, Easing.Linear, null, null);
        }

        private async void DemoSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            await DisplayAlert("Event", "You have searched for " + DemoSearchBar.Text, "OK");
        }
    }
}