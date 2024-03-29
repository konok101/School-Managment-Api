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
        [Route("getStudentBasicInfo")]
        public async Task<ActionResult<List<Student>>> GetStudentDetails()
        {
            var studentList = await _student.GetStudentDetails();
            return Ok(studentList);
        }

        [HttpGet]
        [Route("getStudentCgpa")]
        public async Task<ActionResult<List<Student>>> getGoodStudentNameWithCgpAndPerformance()
        {
            var stu =await _student.getGoodStudentNameWithCgpAndPerformance();
            return Ok(stu);
        }

        [HttpGet]
        [Route("getStudentCgpabyId")]
        public async Task<ActionResult<List<Student>>> getCgpaAndNameById(int id)
        {
            var stu = await _student.getCgpaAndNameById(id);
            return Ok(stu);
        }



    }
}
