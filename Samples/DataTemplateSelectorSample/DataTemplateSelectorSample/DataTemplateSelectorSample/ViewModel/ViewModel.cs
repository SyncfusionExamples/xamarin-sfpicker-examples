using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DataTemplateSelectorSample
{
   public class ViewModel
    {
        /// <summary>
        /// language collection value
        /// </summary>
        private ObservableCollection<Model> languagecollection;

        /// <summary>
        /// Proerty changed event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the value for the Language Collection
        /// </summary>
        public ObservableCollection<Model> LanguageCollection
        {
            get { return languagecollection; }
            set { languagecollection = value; }
        }

        /// <summary>
        /// View model constructor.
        /// </summary>
        public ViewModel()
        {
            LanguageCollection = new ObservableCollection<Model>();
            LanguageCollection.Add(new Model("English",true ));
            LanguageCollection.Add(new Model("French",false ));
            LanguageCollection.Add(new Model("Tamil",true ));
            LanguageCollection.Add(new Model("Japanse",false ));       
            LanguageCollection.Add(new Model("Arabic",false ));
            LanguageCollection.Add(new Model("Chinese",false));
            LanguageCollection.Add(new Model("Urudhu",false ));
            LanguageCollection.Add(new Model("Hindhi",false ));
            LanguageCollection.Add(new Model("Telugu",true ));
            LanguageCollection.Add(new Model("Malayalam",false ));

        }

        /// <summary>
        /// Raise property
        /// </summary>
        /// <param name="name">Name of the property</param>
        void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }    
      }
    }
