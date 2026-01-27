namespace TaskApp.Domain;

public class TaskItem
{
    public long Id { get; set; }
    public string Description { get; set; } = "";
    public string Name { get; set; } = "";
    public long AssignedUser { get; set; }
    public TaskStatusApp Status { get; set; } = TaskStatusApp.Pending;
    public TaskPriority Priority { get; set; } = TaskPriority.Medium;
    public DateOnly DueDate { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
}