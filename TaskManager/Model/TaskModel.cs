using System.ComponentModel.DataAnnotations;

namespace TaskManager.Model
{
    public class TaskModel
    {
        [Key]
        public int Id;
        public string Name;
        public bool IsCompleted { get; set; }
    }
}
