using DP;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C_Computing_Project.GateWayServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherCalController : ControllerBase
    {
        // GET: api/<WeatherCalController>
        [HttpGet]
        public WeatherParams Get([FromQuery] WeatherParams data)
        {
            //http://localhost:5152/api/WeatherCal?City=Tel%20Aviv(מה שאני אמורה לקבל משרת האפליקציה)
            BL.WeatherCal_BL bl = new BL.WeatherCal_BL();
            data = bl.GetWeather(data.City);
            return data;
        }

        // GET api/<WeatherCalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WeatherCalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WeatherCalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WeatherCalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
