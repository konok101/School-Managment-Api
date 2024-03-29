using Microsoft.EntityFrameworkCore;
using School_Managment.DBcontext;
using School_Managment.Inderface;
using School_Managment.Model;
using School_Managment.PresentationModel;

namespace School_Managment.Service
{
    public class StudentRepo : IStudent
    {
        private readonly ApplicationDBcontext _dbcontext;
        public StudentRepo(ApplicationDBcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<demo>> GetAllStudent()
        {
            List<demo>std=new List<demo>();
            std=await Task.FromResult((from E in _dbcontext.Employees
                                       join S in _dbcontext.StudentLists on E.Id equals S.student_id
                                       select new demo
                                       {
                                           name=E.EMPName,
                                           roll=S.roll
                                       }


                ).ToList());
           

            return std;

           // return studentsList;

        }
    }
}
