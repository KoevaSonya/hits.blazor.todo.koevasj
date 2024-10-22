using System.Data;

namespace Todo.ServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDaate { get; set;}
        public DateTime? FinishDaate { get; set; }
    }
}
