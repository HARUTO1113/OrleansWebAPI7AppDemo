using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OrleansWebAPI7AppDemo.Models;

namespace OrleansWebAPI7AppDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SimpleValueController : ControllerBase
    {

        public SimpleValueController()
        {
        }

        [HttpGet()]
        public String TestValue()
        {
            return "愛";
        }


        [HttpGet()]
        public IEnumerable<string> TestArray()
        {
            string[] items = new string[] { "1113", "1405", "1717" };
            return items;
        }

        [HttpGet()]
        public Animal TestObject()
        {
            Animal animal_1 = new Animal();
            animal_1.Name = "カチコミ";
            return animal_1;
        }

        [HttpGet()]
        public IActionResult StatusCode()
        {
            return StatusCode(2500);
        }

        [HttpPost()]
        public Animal TestPostObject(Animal animal)
        {
            animal.Age = 88;
            return animal;
        }
    }
}
