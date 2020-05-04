using FakeTodoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.I2c;

namespace FakeTodoApp.ViewModels
{
    public class TodoItemViewModel : NotificationBase<TodoItem>
    {
        private TodoItem todoItem;

        public TodoItemViewModel()
        {
            todoItem = new TodoItem();
        }

        public string Title
        {
            get
            {
                return This.Title;
            }
            set
            {
                SetProperty(This.Title, value, () => This.Title = value);
            }
        }
    }
}
