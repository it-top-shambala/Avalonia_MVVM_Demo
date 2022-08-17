using System.Collections.ObjectModel;
using Avalonia_MVVM_Demo.App.Lib;
using Avalonia_MVVM_Demo.App.Models;

namespace Avalonia_MVVM_Demo.App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Person> Persons { get; set; }

        public MainWindowViewModel()
        {
            Persons = new ObservableCollection<Person>(WebLib.GetPersons());
        }
    }
}