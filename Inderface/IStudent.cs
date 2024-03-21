using School_Managment.Model;

namespace School_Managment.Inderface
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudent();
     }
}
