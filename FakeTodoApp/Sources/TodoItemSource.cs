using FakeTodoApp.ViewModels;
using Microsoft.Toolkit.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeTodoApp.Sources
{
    public class TodoItemSource : IIncrementalSource<TodoItemViewModel>
    {
        private List<TodoItemViewModel> todoItemViewModels;

        public TodoItemSource()
        {
            todoItemViewModels = new List<TodoItemViewModel>();

            for(int i = 0; i < 1000; i++)
            {
                todoItemViewModels.Add(new TodoItemViewModel
                {
                    Title = $"Hello {i}"
                });
            }
        }

        public async Task<IEnumerable<TodoItemViewModel>> GetPagedItemsAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default)
        {
            await Task.Delay(5 * 1000);
            return todoItemViewModels.Skip(pageIndex * pageSize).Take(pageSize);
        }
    }
}
