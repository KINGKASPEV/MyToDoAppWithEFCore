using System.ComponentModel.DataAnnotations;

namespace MyToDoApp.Model
{
    public class MyToDoItems : BaseEntity
    {
        public string Task { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}