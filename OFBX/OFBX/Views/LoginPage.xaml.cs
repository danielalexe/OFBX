using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OFBX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            LabelVersion.Text +=" "+ VersionTracking.CurrentVersion;
            LabelHardwareID.Text += " No constant as of yet to get a unique id after uninstall/phone reset";
        }

        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private async void ButtonSettings_Clicked(object sender, EventArgs e)
        {
            SettingsPopupPage popupPage = new SettingsPopupPage();
            await PopupNavigation.Instance.PushAsync(popupPage);
        }
    }
}