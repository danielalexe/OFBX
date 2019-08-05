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
    public partial class DemoFieldsPage : ContentPage
    {
        public DemoFieldsPage()
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
            PickerDemo.ItemsSource = list;
            PickerDemo.ItemDisplayBinding = new Binding("nvUSERNAME");
            PickerDemo.SelectedItem = dto;
        }
    }
}