using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cascading
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }

        private void picker_SelectionChanged(object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var color = PickerHelper.GetColor(e.NewValue.ToString());
                if ((Device.RuntimePlatform == Device.Android) || (Device.RuntimePlatform == Device.iOS))
                {
                    picker.BackgroundColor = Color.FromRgba(color.R, color.G, color.B, 0.2);
                }
                else
                    picker.SelectionBackgroundColor = color;

            }
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
            Colors.Add("Purple");
            Colors.Add("Lime");
            Colors.Add("Orange");
            Colors.Add("Gray");
            Colors.Add("Pink");

        }
    }

    public static class PickerHelper
    {
        static Dictionary<string, Color> colors = new Dictionary<string, Color>();

        public static Color GetColor(string color)
        {
            colors.Clear();
            colors.Add("Yellow", Color.Yellow);
            colors.Add("Green", Color.Green);
            colors.Add("Orange", Color.Orange);
            colors.Add("Lime", Color.Lime);
            colors.Add("Purple", Color.Purple);
            colors.Add("Pink", Color.Pink);
            colors.Add("Red", Color.Red);
            colors.Add("Gray", Color.Gray);
            return colors[color.ToString()];
        }
    }
}