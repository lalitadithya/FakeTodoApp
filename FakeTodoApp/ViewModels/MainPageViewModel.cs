using FakeTodoApp.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FakeTodoApp.ViewModels
{
    public class MainPageViewModel : NotificationBase
    {
        public ObservableCollection<TodoItemViewModel> TodoItems { get; }
        public ICommand AddTodoItem { get; }

        public MainPageViewModel()
        {
            TodoItems = new ObservableCollection<TodoItemViewModel>();

            for (int i = 0; i < 10; i++)
            {
                TodoItems.Add(new TodoItemViewModel
                {
                    Title = $"Hello {i}"
                });
            }

            AddTodoItem = new RelayCommand(AddItem);
        }

        private void AddItem(object title)
        {
            TodoItems.Add(new TodoItemViewModel
            {
                Title = title.ToString()
            });
        }
    }
}
