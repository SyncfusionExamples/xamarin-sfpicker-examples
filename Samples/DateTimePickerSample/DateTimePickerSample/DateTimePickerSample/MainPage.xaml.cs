using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DateTimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            //open picker dialog
            date.IsOpen = !date.IsOpen;
        }

        private void date_OnColumnLoaded(object sender, ColumnLoadedEventArgs e)
        {
            //Column width adjusted based on platform
            if (Device.RuntimePlatform == Device.Android)
            {
                if (e.Column == 0)
                    e.ColumnWidth = 400;
                if (e.Column == 1)
                    e.ColumnWidth = 150;
                if (e.Column == 2)
                    e.ColumnWidth = 150;
                if (e.Column == 3)
                    e.ColumnWidth = 200;
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                if (e.Column == 0)
                    e.ColumnWidth = 130;
                if (e.Column == 1)
                    e.ColumnWidth = 50;
                if (e.Column == 2)
                    e.ColumnWidth = 50;
                if (e.Column == 3)
                    e.ColumnWidth = 70;
            }
            else
            {
                if (e.Column == 0)
                    e.ColumnWidth = 130;
            }
        }

    }
}
