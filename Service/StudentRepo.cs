using Microsoft.EntityFrameworkCore;
using School_Managment.DBcontext;
using School_Managment.Inderface;
using School_Managment.Model;

namespace School_Managment.Service
{
    public class StudentRepo : IStudent
    {
        private readonly ApplicationDBcontext _dbcontext;
        public StudentRepo(ApplicationDBcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Student>> GetAllStudent()
        {
            return await _dbcontext.studentInfo.Select(s=> new Student
            {
               student_name = s.student_name,
                age=s.age,
               student_id = s.student_id,
               cgpa=s.cgpa,
                performance=s.performance,
              //  id=s.id,

            }).ToListAsync();
        }
    }
}
