using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebToDo.Models
{
    [Table("Tasks_Table")]
    public class ToDoModel
    {
        [Key]
        public int Id { get; set; }
        public bool TaskCheckbox { get; set; }
        [Required]
        public string TaskTitle { get; set; }
    }
}
