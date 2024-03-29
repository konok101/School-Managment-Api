using School_Managment.PresentationModel;

namespace School_Managment.Inderface
{
    public interface IstudusentNew 
    {
        Task<List<newStudentPresentation>> GetStudentDetails();
    }
}
