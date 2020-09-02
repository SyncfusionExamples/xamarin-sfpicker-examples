using System;
using System.Collections.Generic;
using System.Text;

namespace DataTemplateSelectorSample
{
   public class Model
    {
        /// <summary>
        /// language name value
        /// </summary>
        private string languagename;

        /// <summary>
        /// Is premium value
        /// </summary>
        private bool ispremium;

        /// <summary>
        /// Gets or sets the value of the Language Name 
        /// </summary>
        public string LanguageName
        {
            get { return languagename; }
            set { languagename = value; }
        }

        /// <summary>
        /// Gets or sets the value of the isPremium
        /// </summary>
        public bool IsPremium
        {
            get { return ispremium; }
            set { ispremium = value; }
        }

        /// <summary>
        /// Model constructor
        /// </summary>
        /// <param name="languagename">language name value</param>
        /// <param name="ispremium">ispremium  value</param>
        public Model(string languagename, bool ispremium)
        {
            LanguageName = languagename;
            IsPremium = ispremium;

        }


    }
}
