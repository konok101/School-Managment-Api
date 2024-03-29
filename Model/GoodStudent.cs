using System.ComponentModel.DataAnnotations;

namespace School_Managment.Model
{
    public class GoodStudent
    {
      
      
        public int Id { get; set; }
        public int StudentId { get; set;}
         public int StudentAge { get; set;}
        public int StudentGender { get; set;}
        public int StudentPhone { get; set;}

        public int cgpa { get; set; }

    }
}
