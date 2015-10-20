using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class ToDoItemViewCellViewModel : INotifyPropertyChanged
    {
        public ToDoItemViewCellViewModel(ToDoItem toDo)
        {
            Name = toDo.Name;
            Description = toDo.Description;
        }

        public const string NameProperty = "Name";
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(NameProperty);
            }
        }

        public const string DescriptionProperty = "Description";
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(DescriptionProperty);
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
