using Microsoft.AspNetCore.Mvc;

namespace versioneg{

[ApiController]
[ApiVersion("1.0")]
[Route("api/Employee")] //https://localhost:44381/api/employee?api-version=1.0
//[Route("api/{v:apiVersion}/Employee")] //https://localhost:44381/api/1.0/employee
   public class EmployeeV1Controller:ControllerBase{

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get method from Employee v1 controller");
        }

        [HttpPost]
        public IActionResult AddEmp()
        {
            return Ok();
        }
    }
}