using Microsoft.EntityFrameworkCore;
using ToDoApiList.Models;

namespace TodoApiList.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}