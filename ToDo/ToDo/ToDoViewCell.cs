using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDo
{
    public class ToDoViewCell : TextCell
    {
        public ToDoViewCell()
        {
            this.SetBinding(TextCell.TextProperty, ToDoItemViewCellViewModel.NameProperty);
            this.SetBinding(TextCell.DetailProperty, ToDoItemViewCellViewModel.DescriptionProperty);
        }
    }
}
