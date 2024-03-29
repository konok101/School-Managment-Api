using School_Managment.Model;
using School_Managment.PresentationModel;

namespace School_Managment.Inderface
{
    public interface IStudent
    {
        Task<List<demo>> GetAllStudent();
     }
}
