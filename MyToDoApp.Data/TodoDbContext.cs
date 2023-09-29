using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyToDoApp.Model;

namespace MyToDoApp.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<MyToDoItems> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("Server=DESKTOP-VMTE4F8\\SQL_SERVER;Database=KingsleyEFCore;Trusted_Connection=True;Encrypt=False;");
        }
    }
}


