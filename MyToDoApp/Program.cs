using Microsoft.Extensions.DependencyInjection;
using MyToDoApp.Data;
using MyToDoApp.Data.Repositories.Interfaces;

namespace MyToDoApp
{
    static class Program
    {   
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
                .AddScoped<IToDoRepository, TodoRepository>()
                .AddDbContext<TodoDbContext>(ServiceLifetime.Scoped)
                .BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<TodoDbContext>();
                context.Database.EnsureCreated();
            }
            Application.Run(new Form1(serviceProvider.GetRequiredService<IToDoRepository>()));
        }
    }
}