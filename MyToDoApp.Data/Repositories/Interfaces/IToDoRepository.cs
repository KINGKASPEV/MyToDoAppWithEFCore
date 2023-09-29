using MyToDoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoApp.Data.Repositories.Interfaces
{
    public interface IToDoRepository
    {
        Task<List<MyToDoItems>> GetAllTodoItemsAsync();
        Task<MyToDoItems> GetTodoItemByIdAsync(int id);
        Task<List<MyToDoItems>> AddTodoAsync(MyToDoItems todo);
        Task EditTodoAsync(MyToDoItems todo);
        Task MarkCompleteAsync(int id);
        Task DeleteTodoAsync(int id);
        Task<List<MyToDoItems>> SearchTodoItemsAsync(string searchQuery);
    }
}
