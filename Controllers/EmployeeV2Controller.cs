using Microsoft.AspNetCore.Mvc;

namespace versioneg{

[ApiController]
[ApiVersion("2.0")]
[Route("api/Employee")]
//[Route("api/{v:apiVersion}/Employee")]
   public class EmployeeV2Controller:ControllerBase{

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get method from Employee v2 controller");
        }
    }
}