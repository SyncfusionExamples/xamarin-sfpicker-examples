using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingPickerSample
{
    public class PickerModel
    {
        private string countries;

        public string Countries
        {
            get { return countries; }
            set { countries = value; }
        }


        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string states;

        public string States
        {
            get { return states; }
            set { states = value; }
        }

        private string stateCode;

        public string StateCode
        {
            get { return stateCode; }
            set { stateCode = value; }
        }
    }
}
