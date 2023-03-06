using crud.Services.crudService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IcrudService _crudService;

        public EmployeeController(IcrudService crudService)
        {
            _crudService = crudService;
        }

        [HttpGet]
        public async Task<ActionResult<List<employee>>> GetAll()
        {
            var emp = _crudService.GetAll();
            if (emp == null)
                return NotFound("Error");
            return Ok(emp);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<employee>>> GetSingle(int id)
        {
            var emp = _crudService.GetSingle(id);
            if (emp == null)
                return NotFound("Error");
            return Ok(emp);
        }

        [HttpPost]
        public async Task<ActionResult<List<employee>>> Add(employee empl)
        {
            var emp = _crudService.Add(empl);
            return Ok(emp);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<employee>>> Update (int id, employee request)
        {
            var emp = _crudService.Update(id,request);
            if (emp == null)
                return NotFound("Error");
            return Ok(emp);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<employee>>> Delete (int id)
        {
            var emp = _crudService.Delete(id);
            if (emp == null)
                return NotFound("Error");
            return Ok(emp);
            
        }
    }
}
