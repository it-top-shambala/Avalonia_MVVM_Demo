using System.Collections.ObjectModel;
using Avalonia_MVVM_Demo.App.Lib;
using Avalonia_MVVM_Demo.App.Models;
using ReactiveUI;

namespace Avalonia_MVVM_Demo.App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Person> Persons { get; set; }

        private Person _person;
        public Person Person
        {
            get => _person;
            set => this.RaiseAndSetIfChanged(ref _person, value);
        }

        public MainWindowViewModel()
        {
            Persons = new ObservableCollection<Person>(WebLib.GetPersons());
        }
    }
}