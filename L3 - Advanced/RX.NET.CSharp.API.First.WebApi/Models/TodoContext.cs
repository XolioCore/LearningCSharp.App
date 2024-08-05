using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;

namespace RX.NET.CSharp.API.First.WebApi.Models
{
    public class TodoContext : DbContext {

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
