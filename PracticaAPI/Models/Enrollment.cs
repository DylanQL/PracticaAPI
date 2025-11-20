namespace PracticaAPI.Models;

public class Enrollment
{
    public int idEnrollment { get; set; }
    public int Student_idStudent { get; set; }
    public int Course_idCourse { get; set; }
    public DateTime Date { get; set; }
}