using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ToDo
{
    public class ToDoListPage : ContentPage
    {
        private ToDoListViewModel _viewModel;
        public ToDoListPage()
        {
            _viewModel = new ToDoListViewModel();
            BindingContext = _viewModel;
            Content = ToDoList();
        }
        
        public ListView ToDoList()
        {
            var listView = new ListView()
            {
                ItemTemplate = new DataTemplate(typeof(ToDoViewCell))
            };
            listView.SetBinding(ListView.ItemsSourceProperty, _viewModel.ToDoListProperty);
            

            return listView;
        }
    }
}
