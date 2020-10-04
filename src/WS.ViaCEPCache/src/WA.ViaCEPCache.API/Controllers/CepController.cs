using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WA.ViaCEPCache.Main.Models;
using WA.ViaCEPCache.Main.Services;

namespace WA.ViaCEPCache.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private readonly CepService _service;
        public CepController()
        {
            _service = new CepService();
        }

        [HttpGet("{Cep}")]
        public IActionResult Get(string Cep)
        {
            var result = _service.GetCep(Cep);

            if (result == null) return BadRequest(new {erro = true});

            return Ok(result);

        }
    }
}
