using System.ComponentModel.DataAnnotations;

namespace PracticaAPI.Models;

public class Course
{   
    [Key]
    public int IdCourse { get; set; }
    public string Name { get; set; }
    public int Credit { get; set; }
}