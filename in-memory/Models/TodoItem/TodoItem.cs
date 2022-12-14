using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        [Key]
        public long ID { get; set; }

        public string? Name { get; set; }

        public bool IsComplete { get; set; }

        public string? Secret { get; set; }
    }
}