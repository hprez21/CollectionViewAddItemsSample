using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewAddItemsSample
{
     [AddINotifyPropertyChangedInterface]
     public class MainPageModel
     {
          public ObservableCollection<Person> People { get; set; } =
               new ObservableCollection<Person>();
          public string NameToAdd { get; set; }
          public ICommand AddCommand =>
               new Command(() =>
               {
                    People.Add(
                         new Person
                         {
                              Name = NameToAdd
                         });
               });
     }
}
