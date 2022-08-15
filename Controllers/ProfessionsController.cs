using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using undisclosed_back.Service;
using FluentResults;
using undisclosed_back.Service;


namespace undisclosed_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessionsController : ControllerBase
    {
        private ProfessionService _professionService;

        public ProfessionsController(ProfessionService professionService)
        {
            _professionService = professionService;
        }

        [HttpGet]
        public IActionResult  GetProfessions()
        {
         Result professions = _professionService.GetProfessions();
        return Ok(professions.Successes);
    
        }


        // [HttpPost]
        // public IActionResult setProfessions() 
        // {

        // }
    }
}