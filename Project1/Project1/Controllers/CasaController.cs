using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using Project1.Repositories;
using Project1.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasaController : ControllerBase
    {
        private readonly ICasaService _casaService;
        private readonly ICasaRepository _casaRepository;

        public CasaController(ICasaService casaService, ICasaRepository casaRepository)
        {
            _casaService = casaService;
            _casaRepository = casaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_casaService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_casaService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] Casa casa)
        {
            _casaRepository.Create(casa);
            _casaRepository.SaveChanges();
            var result = _casaRepository.GetCasaAllDetails(casa.CasaId);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromForm] Casa casa)
        {
            return Ok(_casaService.Update(casa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_casaService.Delete(id));
        }
    }
}
