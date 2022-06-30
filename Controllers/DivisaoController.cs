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
    public class TesteController : ControllerBase
    {
        // GET: api/Teste
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Teste/5
        [HttpGet("{num1}/{num2}", Name = "Get")]
        public string Get(int num1, double num2)
        {
           var Divisao = num1 / num2;

            if (num2 == 0)
            {
                return $"Divisão nula ";
            }
            else
            {
                return $"O valor da divisão é {Divisao}";
            } 
        
        }

      
    }
}
