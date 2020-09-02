using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTemplateSelectorSample
{
    public partial class MainPage : ContentPage
    {
        //SfPicker picker = new SfPicker();
        //DataTemplate defaultTemplate;
        //DataTemplate specifictempalte;
        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = new ViewModel();
            //ViewModel view = new ViewModel();


            //defaultTemplate = new DataTemplate(() =>
            //{
            //    Grid grid = new Grid();
            //    Label label = new Label();
            //    label.SetBinding(Label.TextProperty, "LanguageName");
            //    label.HorizontalOptions = LayoutOptions.Center;
            //    label.VerticalOptions = LayoutOptions.Center;
            //    label.FontSize = 20;
            //    grid.Children.Add(label);
            //    return grid;
            //});

            //specifictempalte = new DataTemplate(() =>
            //{
            //    Grid maingrid = new Grid();
            //    Grid labelgrid = new Grid();
            //    Grid imagegrid = new Grid();
            //    Label label = new Label();
            //    Image image = new Image();
            //    label.SetBinding(Label.TextProperty, "LanguageName");
            //    label.FontSize = 20;
            //    label.HorizontalOptions = LayoutOptions.Center;
            //    label.VerticalOptions = LayoutOptions.Center;
            //    image.Source = "Crown.png";
            //    image.HeightRequest = 15;
            //    image.WidthRequest = 15;
            //    image.HorizontalOptions = LayoutOptions.Center;
            //    image.VerticalOptions = LayoutOptions.Center;
            //    labelgrid.Children.Add(label);
            //    imagegrid.Children.Add(image);
            //    imagegrid.Padding = new Thickness(-80, 0, 0, 0);
            //    maingrid.Children.Add(labelgrid);
            //    maingrid.Children.Add(imagegrid);
            //    return maingrid;
            //});

            //Grid mainGrid = new Grid();
            //RowDefinition firstrow = new RowDefinition();
            //RowDefinition secondrow = new RowDefinition();

            //Button button = new Button();
            //button.Clicked += Button_Clicked;
            //button.HorizontalOptions = LayoutOptions.Center;
            //button.VerticalOptions = LayoutOptions.Center;
            //button.Text = "Pick a Language";
            //Grid.SetRow(button, 0);

            //picker.ShowHeader = true;
            //picker.ShowFooter = true;
            //picker.HeaderText = "Select a Language";
            //picker.PickerMode = PickerMode.Dialog;
            //picker.ItemsSource = view.LanguageCollection;
            //picker.ItemTemplate = new DataTemplateSelectorViewModel { DefaultTemplate = defaultTemplate, SpecificTemplate = specifictempalte };
            //Grid.SetRow(picker, 1);
            

            //mainGrid.RowDefinitions.Add(firstrow);
            //mainGrid.RowDefinitions.Add(secondrow);
            //mainGrid.Children.Add(button);
            //mainGrid.Children.Add(picker);
            //firstrow.Height = new GridLength(80);
            //secondrow.Height = new GridLength(500);

            //this.Content = mainGrid;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           picker.IsOpen = true;
        }
       
    }
}
