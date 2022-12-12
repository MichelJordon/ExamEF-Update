namespace Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class JobHistory{
    [Key]
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int JobId{get; set;}
    public virtual Job Job{get; set;}
    public int DepartmentId{get;set;}
    public virtual Department Department{get; set;}
    public virtual Employee Employee {get; set;}
}