namespace PracticaAPI.Models;

public class Student
{
    public int IdStudent { get; set; }
    public int GradeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    
    //Navigation Properties
    public Grade Grade { get; set; }
}