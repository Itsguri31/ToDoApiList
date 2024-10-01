using System;

namespace ToDoApiList.Models
{
    public class TodoItem
    {
        public int Id { get; set; } 

        public DateTime DueDate { get; set; } 

        public DateTime? CompletedDate { get; set; } 

        public string Discription { get; set; } 
    }
}
