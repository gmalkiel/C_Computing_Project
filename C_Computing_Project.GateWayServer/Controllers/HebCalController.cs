using DP;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C_Computing_Project.GateWayServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HebCalController : ControllerBase
    {
        // GET: api/<WebCalController>
        [HttpGet]
        public HebCalParams Get([FromQuery]HebCalParams data)
        {
            //http://localhost:5152/api/HebCal?City=IL-Tel%20Aviv(מה שאני צריכה לקבל משרת האפליקציה)
            BL.HebCal_BL bl=new BL.HebCal_BL();
            data= bl.MonthlyHoliday(data.City);
            return data;
        }

        // GET api/<WebCalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebCalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WebCalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebCalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
