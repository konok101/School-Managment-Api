using System.ComponentModel.DataAnnotations;

namespace School_Managment.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string EMPName { get; set; }
      
        public int EmployeeId { get; set; }
       // public Student Student { get; set; }    
    }
}
