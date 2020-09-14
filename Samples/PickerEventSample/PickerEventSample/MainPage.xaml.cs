using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerEventSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            picker.Closing += this.Picker_Closing;
        }

        private bool isClosed = true;
        private void Picker_Closing(object sender, Syncfusion.XForms.Core.CancelEventArgs e)
        {
            e.Cancel = isClosed;
        }

        private void picker_Opened(object sender, EventArgs e)
        {
            //This call when picker get open
        }

        private void picker_Closed(object sender, EventArgs e)
        {
            //This call after the picker get closed.
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            isClosed = true;
            picker.IsOpen = true;
        }

        private void picker_OkButtonClicked(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            picker.IsOpen = false;
            isClosed = false;
        }

        private void picker_CancelButtonClicked(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            picker.IsOpen = false;
            isClosed = false;
        }
    }
    public class ColorInfo

    {

        private ObservableCollection<string> _color;

        public ObservableCollection<string> Colors

        {
            get { return _color; }
            set { _color = value; }
        }

        public ColorInfo()

        {

            Colors = new ObservableCollection<string>();

            Colors.Add("Red");

            Colors.Add("Green");

            Colors.Add("Yellow");

            Colors.Add("Blue");

            Colors.Add("SkyBlue");

            Colors.Add("Orange");

            Colors.Add("Gray");

            Colors.Add("Pink");

        }
    }
}
