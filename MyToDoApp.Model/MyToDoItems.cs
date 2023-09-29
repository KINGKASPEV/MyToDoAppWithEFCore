using System.ComponentModel.DataAnnotations;

namespace MyToDoApp.Model
{
    public class MyToDoItems
    {
        [Key]
        public int Id { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        //public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; } // Date when the task was created
        public DateTime UpdatedAt { get; set; } // Date when the task was last updated
        public bool IsCompleted { get; set; }// Indicates if the task is completed
    }
}