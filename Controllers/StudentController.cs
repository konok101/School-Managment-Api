using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School_Managment.Inderface;
using School_Managment.Model;

namespace School_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;

        public StudentController(IStudent studentRepo)
        {
            _student = studentRepo;
        }

        [HttpGet]
        [Route("GETSTUDENTlIST")]
        public async Task<ActionResult<List<Student>>> GetAllStudent()
        {
            var studentList = await _student.GetAllStudent();
            return studentList;
        }





    }
}
