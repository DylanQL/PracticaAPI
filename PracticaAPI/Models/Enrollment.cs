using System.ComponentModel.DataAnnotations;

namespace PracticaAPI.Models;

public class Enrollment
{   
    [Key]
    public int IdEnrollment { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateTime Date { get; set; }
    
    //Navigation Properties
    public Student Student { get; set; }
    public Course Course { get; set; }
}