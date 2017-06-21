using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Models;
using Xamarin.Forms;

namespace ToDo.MasterPages
{
    class ListItemCode : ContentPage
    {
        private ObservableCollection<TodoItem> TodoItems { get; set; }

        public ListItemCode()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            ListView listView = new ListView();
            TodoItems.Add(new TodoItem() { ID = 1, Name = "Görev 1", Done = true });
            TodoItems.Add(new TodoItem() { ID = 1, Name = "Görev 2", Done = false });
            listView.ItemsSource = TodoItems;



        }

    }
}
