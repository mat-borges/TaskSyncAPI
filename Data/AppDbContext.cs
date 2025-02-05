using Microsoft.EntityFrameworkCore;
using TaskSyncAPI.Models;

namespace TaskSyncAPI.Data;

public class AppDbContext : DbContext {
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<TaskItem> Tasks { get; set; }
}
