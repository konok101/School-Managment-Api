using School_Managment.PresentationModel;

namespace School_Managment.Inderface
{
    public interface IstudusentNew 
    {
        Task<List<newStudentPresentation>> GetStudentDetails();
        
        //get all student
        Task<List<newStudentPresentation>>getGoodStudentNameWithCgpAndPerformance();
        Task<List<newStudentPresentation>>getCgpaAndNameById(int id);

        Task<List<newStudentPresentation>> groupByPerformance();

    }
}
