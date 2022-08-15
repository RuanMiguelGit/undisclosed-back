using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;


namespace undisclosed_back.Service
{
    public class ProfessionService
    {
        private IMapper _mapper; 

        public ProfessionService(IMapper mapper)
        {
         _mapper = mapper;   
        }

       public Result GetProfessions()
       {

            return Result.Ok().WithSuccess("sad");
       }

        
    }
}