using System.ComponentModel.DataAnnotations;

namespace PracticaAPI.Models;

public class Grade
{   
    [Key]
    public int IdGrade { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}