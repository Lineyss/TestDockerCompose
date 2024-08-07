using API.DataBaseExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController(ILogger<TestController> logger, DataBaseContext db) : ControllerBase
    {
        public readonly ILogger<TestController> logger = logger;
        public readonly DataBaseContext db = db;

        [HttpGet(Name = "GetTestModels")]
        public async Task<IActionResult> GetAll() => Ok(await db.tests.ToListAsync());

        /*[HttpGet(Name = "GetTestModel")]
        [Route("{ID}")]
        public async Task<IActionResult> GetById(Guid id)
        {

        }

        [HttpPost(Name = "CreateTestModel")]
        public async Task<IActionResult> Post(string Title)
        {

        }*/
    }
}
