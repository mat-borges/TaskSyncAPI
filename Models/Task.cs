namespace TaskSyncAPI.Models;

public class TaskItem {
	 public int Id { get; set; }
	 public string Name { get; set; }
	 public string Description { get; set; }
	 public DateTime DueDate { get; set; }
	 public bool IsComplete { get; set; }
	 public DateTime CreatedAt { get; set; }
}