using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Student
{
    [Required]
    public string StudentID { get; set; } = " ";
    [Required]
    public string FirstName { get; set; } = " ";
    [Required]
    public string LastName { get; set; } = " ";
    public Student()
	{
		
	}
}
