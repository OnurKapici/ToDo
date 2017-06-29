using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.MasterPages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMaster : ContentPage
    {
       

        public MyMaster()
        {

            
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here

            var items2 = new List<TodoItem>();
            items2.Add(new TodoItem() { ID = 3, Name = "Günüm", Done = true });
            items2.Add(new TodoItem() { ID = 4, Name = "Listem", Done = false });
            listViewMenu.ItemsSource = items2;
        }

    }

    class MyMasterViewModel : INotifyPropertyChanged
    {

        public MyMasterViewModel()
        {
            IncreaseCountCommand = new Command(IncreaseCount);
        }

        int count;

        string countDisplay = "You clicked 0 times.";
        public string CountDisplay
        {
            get { return countDisplay; }
            set { countDisplay = value; OnPropertyChanged(); }
        }

        public ICommand IncreaseCountCommand { get; }

        void IncreaseCount() =>
            CountDisplay = $"You clicked {++count} times";


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
