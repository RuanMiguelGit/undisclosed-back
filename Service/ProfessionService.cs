using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using undisclosed_back.Data;
using undisclosed_back.Models;



namespace undisclosed_back.Service
{
    public class ProfessionService
    {
        private IMapper _mapper; 
        private AppDbContext _context;


        public ProfessionService(IMapper mapper, AppDbContext context)
        {
         _mapper = mapper;
         _context = context;
        }

       public List<Professions> GetProfessions()
       {
         List<Professions> professions = _context.Professions.ToList();
            // return Result.Ok().WithSuccess(professions);
            return professions;
       }

        
    }
}