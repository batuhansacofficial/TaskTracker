public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Task(int id, string description)
    {
        Id = id;
        Description = description;
        Status = "Pending";
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{Id}] {Description} - {Status} (Created on {CreatedAt:yyyy-MM-dd HH:mm:ss}, Updated on {UpdatedAt:yyyy-MM-dd HH:mm:ss})";
    }
}
