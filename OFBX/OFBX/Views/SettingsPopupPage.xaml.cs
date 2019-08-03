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
    public partial class SettingsPopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public SettingsPopupPage()
        {
            InitializeComponent();
            var ServerIPValue = Preferences.Get("ServerIP", "");
            if (String.IsNullOrEmpty(ServerIPValue))
            {
                Preferences.Set("ServerIP", "192.168.1.105");
                EditorServerIP.Text = "192.168.1.105";
            }
            else
            {
                EditorServerIP.Text = ServerIPValue;
            }

            var ServiceNameValue = Preferences.Get("ServiceName", "");
            if (String.IsNullOrEmpty(ServerIPValue))
            {
                Preferences.Set("ServiceName", "APILightWeb");
                EditorServiceName.Text = "APILightWeb";
            }
            else
            {
                EditorServiceName.Text = ServiceNameValue;
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        // ### Methods for supporting animations in your popup page ###

        // Invoked before an animation appearing
        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();
        }

        // Invoked after an animation appearing
        protected override void OnAppearingAnimationEnd()
        {
            base.OnAppearingAnimationEnd();
        }

        // Invoked before an animation disappearing
        protected override void OnDisappearingAnimationBegin()
        {
            base.OnDisappearingAnimationBegin();
        }

        // Invoked after an animation disappearing
        protected override void OnDisappearingAnimationEnd()
        {
            base.OnDisappearingAnimationEnd();
        }

        protected override Task OnAppearingAnimationBeginAsync()
        {
            return base.OnAppearingAnimationBeginAsync();
        }

        protected override Task OnAppearingAnimationEndAsync()
        {
            return base.OnAppearingAnimationEndAsync();
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return base.OnDisappearingAnimationBeginAsync();
        }

        protected override Task OnDisappearingAnimationEndAsync()
        {
            return base.OnDisappearingAnimationEndAsync();
        }

        // ### Overrided methods which can prevent closing a popup page ###

        // Invoked when a hardware back button is pressed
        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }

        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }

        private async void ButtonSave_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(EditorServerIP.Text))
            {
                Preferences.Set("ServerIP", EditorServerIP.Text);
            }
            if (!String.IsNullOrEmpty(EditorServiceName.Text))
            {
                Preferences.Set("ServiceName", EditorServiceName.Text);
            }
            await PopupNavigation.Instance.RemovePageAsync(this);
        }

        private async void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.RemovePageAsync(this);
        }
    }
}