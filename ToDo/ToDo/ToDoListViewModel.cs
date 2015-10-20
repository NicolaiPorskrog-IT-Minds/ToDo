using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace ToDo
{
    public class ToDoListViewModel : INotifyPropertyChanged
    {
        public ToDoListViewModel()
        {
            var toDoItem = new ToDoItem
            {
                Name = "Cleaning",
                Description = "Clean the bathroom"
            };
            var toDoViewCellViewModel = new ToDoItemViewCellViewModel(toDoItem);
            for (var i = 0; i < 20; i++)
            {
                ToDoList.Add(toDoViewCellViewModel);
            }
        }

        public string ToDoListProperty = "ToDoList";
        private ObservableCollection<ToDoItemViewCellViewModel> _toDoList;
        public ObservableCollection<ToDoItemViewCellViewModel> ToDoList
        {
            get { return _toDoList ?? (_toDoList = new ObservableCollection<ToDoItemViewCellViewModel>()); }
            set
            {
                _toDoList = value;
                OnPropertyChanged(ToDoListProperty);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
