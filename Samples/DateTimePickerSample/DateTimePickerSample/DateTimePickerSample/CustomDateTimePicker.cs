using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace DateTimePickerSample
{
    public class CustomDateTimePicker : SfPicker
    {
        // Datetime api is used to modify the Date collection as per change in Datetime
        /// <summary>
        /// Datetime is the acutal DataSource for SfPicker control which will holds the collection of Date, Hour, Minute and Format
        /// </summary>
        public ObservableCollection<object> Datetime { get; set; }

        //Date is the collection of date with day and month

        public ObservableCollection<object> Date;

        //Minute is the collection of minute numbers

        public ObservableCollection<object> Minute;

        //Hour is the collection of hour numbers

        public ObservableCollection<object> Hour;

        //Format is the collection of AM and PM

        public ObservableCollection<object> Format;

        /// <summary>
        /// Header api is holds the column name for every column in datetime picker
        /// </summary>
        public ObservableCollection<string> Headers { get; set; }
        public CustomDateTimePicker()
        {
            Datetime = new ObservableCollection<object>();

            Date = new ObservableCollection<object>();
            Minute = new ObservableCollection<object>();
            Hour = new ObservableCollection<object>();
            Format = new ObservableCollection<object>();
            Headers = new ObservableCollection<string>();

            Headers.Add("Date");
            Headers.Add("Hrs");
            Headers.Add("Min");
            Headers.Add("Format");

            PopulateCollections(Datetime);
            this.ItemsSource = Datetime;
            this.ColumnHeaderText = Headers;

            //SfPicker header text
            HeaderText = "DATE TIME PICKER";

            //Enable Footer of SfPicker
            ShowFooter = true;

            //Enable Header of SfPicker
            ShowHeader = true;

            //Enable Column Header of SfPicker
            ShowColumnHeader = true;
        }

        private void PopulateCollections(ObservableCollection<object> datetime)
        {
            //Populate Date
            int noofdays = DateTime.DaysInMonth(DateTime.Now.Date.Year, DateTime.Now.Date.Month);

            for (int i = 1; i <= noofdays; i++)
            {
                string date = string.Empty;
                if (i != DateTime.Now.Date.Day)
                {
                    DayOfWeek name = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, i).DayOfWeek;

                    date = name.ToString().Substring(0, 3) + " ";
                    date += CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Date.Month).Substring(0, 3) + " ";

                    if (i < 10)
                        date += "0" + i.ToString();
                    else
                        date += i.ToString();
                }
                else
                {
                    date = "Today";
                }
                //Populate Day with Month
                Date.Add(date);
            }

            //Populate Hour
            for (int i = 1; i <= 12; i++)
            {
                Hour.Add(i.ToString());

            }
            //Populate Minute
            for (int j = 0; j < 60; j++)
            {
                if (j < 10)
                {
                    Minute.Add("0" + j);
                }
                else
                    Minute.Add(j.ToString());

            }

            //Populate Format
            Format.Add("AM");
            Format.Add("PM");

            Datetime.Add(Date);
            Datetime.Add(Hour);
            Datetime.Add(Minute);
            Datetime.Add(Format);
        }

    }
}

