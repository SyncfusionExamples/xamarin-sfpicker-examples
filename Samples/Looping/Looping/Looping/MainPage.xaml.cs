using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Looping
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ColorInfo continentinfo = new ColorInfo();
            button.Clicked += Button_Clicked;
            picker.SelectedItemFontSize = 25;
            picker.EnableLooping = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }
    }
    public class ColorInfo
    {
        private ObservableCollection<string> color;

        //update the Continents
        public ObservableCollection<string> Color
        {
            get { return color; }
            set { color = value; }
        }

        public ColorInfo()
        {
            Color = new ObservableCollection<string>();

            Color.Add("Yellow");

            Color.Add("Green");

            Color.Add("Navy");

            Color.Add("Orange");

            Color.Add("Lime");

            Color.Add("Purple");

            Color.Add("Pink");

            Color.Add("Red");

            Color.Add("Gray");

        }
    }
}