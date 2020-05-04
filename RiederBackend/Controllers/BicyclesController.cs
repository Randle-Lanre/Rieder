using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RiederBackend.Dtos;
using RiederBackend.Model;

namespace RiederBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BicyclesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<BicyclesController> _logger;

        public BicyclesController(ApplicationDbContext context, IMapper mapper, ILogger<BicyclesController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("{id: int}")]
        public async Task<ActionResult<BicycleDto>> Get (int id)
        {

            var bicycle = await _context.Bicycles.FirstOrDefaultAsync(x => x.Id == id);

            if (bicycle == null)
                return NotFound();

            var bicycleDto = _mapper.Map<BicycleDto>(bicycle);

            return bicycleDto;


        }


       
    }
}
