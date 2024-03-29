using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School_Managment.Inderface;
using School_Managment.Model;

namespace School_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewStudentController : ControllerBase
    {

        private readonly IstudusentNew _student;

        public NewStudentController(IstudusentNew studentRepo)
        {
            _student = studentRepo;
        }


        [HttpGet]
        [Route("mss")]
        public async Task<ActionResult<List<Student>>> GetStudentDetails()
        {
            var studentList = await _student.GetStudentDetails();
            return Ok(studentList);
        }





    }
}
