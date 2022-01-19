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
    public class AdresaController : ControllerBase
    {
        private readonly IAdresaService _adresaService;
        private readonly IAdresaRepository _adresaRepository;

        public AdresaController(IAdresaService adresaService, IAdresaRepository adresaRepository)
        {
            _adresaService = adresaService;
            _adresaRepository = adresaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_adresaService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_adresaService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] Adresa adresa)
        {
            _adresaRepository.Create(adresa);
            _adresaRepository.SaveChanges();
            var result = _adresaRepository.GetAdresaAllDetails(adresa.AdresaId);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromForm] Adresa adresa)
        {
            return Ok(_adresaService.Update(adresa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_adresaService.Delete(id));
        }
    }
}
