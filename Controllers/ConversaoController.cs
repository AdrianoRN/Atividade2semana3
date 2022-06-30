using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Minha_primeira_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversaoController : ControllerBase
    {
        // GET: api/Conversao
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

      
        

        // POST: api/Conversao
        [HttpPost]
        public string  Post([FromBody]string value)
        {  
          var num3= Convert.ToUInt64(value);
            
          var F = (num3 * 1.8 ) + 32 ;
          var ConverterF= Convert.ToString(F);      
               
            
            return"O valor em fahrenheit é "+ConverterF;

            
        }
        


        

        // PUT: api/Conversao/5
        [HttpPut("{value}")]
        public string Put(   [FromBody] string value)
        {
            var num4= Convert.ToUInt64(value);
            
          var F = (num4 -32 ) / 1.8 ;
          var ConverterF= Convert.ToString(F);      
               
            
            return"O valor em Celsius é "+ConverterF;

        }

        // DELETE: api/Conversao/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
