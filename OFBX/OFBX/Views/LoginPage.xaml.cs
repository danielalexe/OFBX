using Flurl;
using Flurl.Http;
using OFBX.DataObjects;
using OFBX.Helpers;
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

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            DTOUser user = new DTOUser();
            user.nvUSERNAME = EntryUsername.Text;
            user.nvPASSWORD = EntryPassword.Text;

            var ConnectionStatus = Connectivity.NetworkAccess;

            if (ConnectionStatus == NetworkAccess.Internet)
            {
                // Connection to internet is available

                LoadingPopupPage popupPage = new LoadingPopupPage();
                await PopupNavigation.Instance.PushAsync(popupPage);

                try
                {
                    //var result = await NetworkHelper.GetConnectionURL(NetworkHelper.ConnectionSecurity.Unsecure)
                    //            .AppendPathSegment(NetworkHelper.TestConnection)
                    //            .PostJsonAsync(user)
                    //            .ReceiveJson<GenericResult<DTOUser>>();
                    var result = await NetworkHelper.GetConnectionURL(NetworkHelper.ConnectionSecurity.Unsecure)
                                .AppendPathSegment(NetworkHelper.TestConnection)
                                .GetAsync();


                    await PopupNavigation.Instance.RemovePageAsync(popupPage);

                    if (result.IsSuccessStatusCode == false)
                    {
                        await DisplayAlert("Error", "Wrong username or password", "OK");
                    }
                    else
                    {
                        App.Current.MainPage = new NavigationPage(new MainMenuPage());
                    }
                }
                catch (Exception ex)
                {
                    await PopupNavigation.Instance.RemovePageAsync(popupPage);
                    await DisplayAlert("Error", "Wrong username or password", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Internet connection not available", "OK");
            }


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