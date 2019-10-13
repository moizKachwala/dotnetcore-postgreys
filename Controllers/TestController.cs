using dockerapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class TestController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TestController(ApiDbContext context)
        {
            _context = context;
        }
#pragma warning restore CS1591

        [HttpGet]
        public object Get()
        {
            return _context.Tests.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Test> Get(int id)
        {
            var test = _context.Tests
                .FirstOrDefault(g => g.Id == id);
            if (test == null)
            {
                return NotFound();
            }
            return test;
        }

        [HttpPost]
        public ActionResult<Test> Post([FromBody] Test test)
        {
            _context.Tests.Add(test);
            return new OkObjectResult(test);
        }

        // PUT api/test/1
        [HttpPut("{id}")]
        public ActionResult<Test> Put(long id, [FromBody] Test test)
        {
            var testfromDb = _context.Tests
                .FirstOrDefault(g => g.Id == id);

            if (testfromDb == null)
                return new NotFoundResult();

            test.Id = testfromDb.Id;
            _context.Update(test);
            return new OkObjectResult(test);
        }

        // DELETE api/users/1
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var test = _context.Tests
                .FirstOrDefault(g => g.Id == id);

            if (test == null)
                return new NotFoundResult();

            _context.Remove(test);
            return new OkResult();
        }
    }
}