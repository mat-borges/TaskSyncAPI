namespace TaskSyncAPI.Models;

public class TaskItem {
	 public int Id { get; set; }
	 public string Name { get; set; } = string.Empty;
	 public string Description { get; set; } = string.Empty;
	 public DateTime DueDate { get; set; }
	 public bool IsComplete { get; set; } = false;
	 public DateTime CreatedAt { get; set; } = DateTime.Now;
}