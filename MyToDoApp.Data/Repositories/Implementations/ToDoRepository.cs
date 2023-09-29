using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyToDoApp.Model;
using MyToDoApp.Data.Repositories.Interfaces;

namespace MyToDoApp.Data
{
    public class TodoRepository : IToDoRepository
    {
        private readonly TodoDbContext _context;

        public TodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        public async Task<List<MyToDoItems>> GetAllTodoItemsAsync()
        {
            return await _context.Todos.ToListAsync();
        }
        public async Task<MyToDoItems> GetTodoItemByIdAsync(int id)
        {
            return await _context.Todos.FindAsync(id);
        }

        public async Task<List<MyToDoItems>> AddTodoAsync(MyToDoItems todo)
        {
            todo.CreatedAt = DateTime.Now;
            todo.UpdatedAt = DateTime.Now;
            todo.IsCompleted = false; 
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            var sortedTodoItems = await _context.Todos.OrderByDescending(t => t.Id).ToListAsync();
            return sortedTodoItems;
        }

        public async Task EditTodoAsync(MyToDoItems todo)
        {
            todo.UpdatedAt = DateTime.Now;
            _context.Entry(todo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTodoAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task MarkCompleteAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                todo.IsCompleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<MyToDoItems>> SearchTodoItemsAsync(string searchQuery)
        {
            return await _context.Todos
                .Where(t => t.Task.Contains(searchQuery) || t.Description.Contains(searchQuery) || t.CreatedAt.ToString().Contains(searchQuery))
                .ToListAsync();
        }
    }
}


