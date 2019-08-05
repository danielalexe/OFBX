using OFBX.DataObjects;
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
    public partial class DemoListViewPage : ContentPage
    {
        public DemoListViewPage()
        {
            InitializeComponent();

            List<DTOUser> list = new List<DTOUser>();
            DTOUser dto = new DTOUser();
            dto.iID_USER = 1;
            dto.nvUSERNAME = "Demo 1";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 2;
            dto.nvUSERNAME = "Demo 2";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 3;
            dto.nvUSERNAME = "Demo 3";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 4;
            dto.nvUSERNAME = "Demo 4";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 5;
            dto.nvUSERNAME = "Demo 5";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 6;
            dto.nvUSERNAME = "Demo 6";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 7;
            dto.nvUSERNAME = "Demo 7";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 8;
            dto.nvUSERNAME = "Demo 8";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 9;
            dto.nvUSERNAME = "Demo 9";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 10;
            dto.nvUSERNAME = "Demo 10";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 11;
            dto.nvUSERNAME = "Demo 11";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 12;
            dto.nvUSERNAME = "Demo 12";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 13;
            dto.nvUSERNAME = "Demo 13";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 14;
            dto.nvUSERNAME = "Demo 14";
            list.Add(dto);
            dto = new DTOUser();
            dto.iID_USER = 15;
            dto.nvUSERNAME = "Demo 15";
            list.Add(dto);

            DemoListView.ItemsSource = list;

        }

        private async void DemoListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Event", "You have clicked the item "+((DTOUser)e.Item).nvUSERNAME, "OK");
        }
    }
}