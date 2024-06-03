using BlazorAppToDo.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppToDo.Data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<Todo> Todos{ get; set; } = default;
    }
}
