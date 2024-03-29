using School_Managment.DBcontext;
using School_Managment.Inderface;
using School_Managment.PresentationModel;

namespace School_Managment.Service
{
    public class StudentRepoNew : IstudusentNew
    {
        private readonly ApplicationDBcontext _dbcontext;
        public StudentRepoNew(ApplicationDBcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<newStudentPresentation>> GetStudentDetails()
        { 
            List <newStudentPresentation> myList = new List<newStudentPresentation>();
            myList = await Task.FromResult((from S in _dbcontext.StudentLists
                                            join I in _dbcontext.Employees on S.student_id equals I.EmployeeId
                                            select new newStudentPresentation
                                            {
                                                name = I.EMPName,
                                                roll = S.roll,
                                                studentEnroll= S.student_id
                                            }).ToList());
            return myList;

        }

        public async Task<List<newStudentPresentation>> getGoodStudentNameWithCgpAndPerformance()
        {
            List <newStudentPresentation> myList = new List<newStudentPresentation>();
            myList = await Task.FromResult((from S in _dbcontext.StudentLists join I in _dbcontext.Employees on S.student_id equals I.EmployeeId
                                            join G in _dbcontext.GoodStudentList on S.student_id equals G.StudentId select new newStudentPresentation
                                            {
                                                name = I.EMPName,
                                                roll = S.roll,
                                                cgpaStu = G.cgpa
                                            }
                                            ).ToList());
            return myList;
         }

 
        public async Task<List<newStudentPresentation>> getCgpaAndNameById(int id)
        {
            List<newStudentPresentation> myList = new List<newStudentPresentation>();
            myList = await Task.FromResult((from S in _dbcontext.StudentLists
                                            join I in _dbcontext.Employees on S.student_id equals I.EmployeeId
                                            join G in _dbcontext.GoodStudentList on S.student_id equals G.StudentId
                                           where G.StudentId == id select new newStudentPresentation
                                            {
                                                name = I.EMPName,
                                                 cgpaStu = G.cgpa
                                            }
                                            ).ToList());
            return myList;


        }


    }
}
