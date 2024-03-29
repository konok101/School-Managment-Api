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
                                            join I in _dbcontext.Employees on S.student_id equals I.Id
                                            select new newStudentPresentation
                                            {
                                                name = I.EMPName,
                                                roll = S.roll
                                            }).ToList());
            return myList;

        }
    }
}
