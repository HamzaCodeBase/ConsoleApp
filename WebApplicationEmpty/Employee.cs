using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationEmpty
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Office Office { get; set; }  ///One to One 
        public int? OfficeId { get; set; }

        public Department Department { get; set; }  ///One to Many
        public int? DepartmentId { get;set; }

        public List<Project> Projects { get; set;}
    }
}
