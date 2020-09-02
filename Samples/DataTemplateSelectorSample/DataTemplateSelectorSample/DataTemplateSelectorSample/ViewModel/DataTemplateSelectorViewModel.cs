using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataTemplateSelectorSample
{
   public class DataTemplateSelectorViewModel : DataTemplateSelector
    {
        /// <summary>
        /// default template value.
        /// </summary>
        private DataTemplate defaulttemplate;

        /// <summary>
        /// specific template value
        /// </summary>
        private DataTemplate specifictemplate;

        /// <summary>
        /// Gets or sets the value for the DefaultTemplate
        /// </summary>
        public DataTemplate DefaultTemplate
        {
            get { return defaulttemplate; }
            set { defaulttemplate = value; }
        }

        /// <summary>
        /// Gets or sets the value for the SpecificTemplate
        /// </summary>
        public DataTemplate SpecificTemplate
        {
            get { return specifictemplate; }
            set { specifictemplate = value; }
        }

        /// <summary>
        /// On select template which returnt the specific template
        /// </summary>
        /// <param name="item">Item value</param>
        /// <param name="container">Container value</param>
        /// <returns>return template</returns>
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as Model;
            if (message == null)
                return null;
            return message.IsPremium ? SpecificTemplate : DefaultTemplate; 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
