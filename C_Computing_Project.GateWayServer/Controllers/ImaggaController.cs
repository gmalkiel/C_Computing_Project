using DP;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C_Computing_Project.GateWayServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImaggaController : ControllerBase
    {
        // GET: api/<ImaggaController>
        [HttpGet]
        public bool Get([FromQuery]ImaggaParams data)
        {
            //http://localhost:5152/api/Imagga?ImageSource=Url(מה שאני אמורה לקבל משרת האפליקציה)
            BL.Imagga_BL bl=new BL.Imagga_BL();
            data = bl.PicDetails(data.ImageSource);
            return data.IsFood;
        }

        // GET api/<ImaggaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImaggaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ImaggaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImaggaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
