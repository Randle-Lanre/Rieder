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
using RiederBackend.Entities;
using RiederBackend.Model;

namespace RiederBackend.Controllers
{
    [ApiController]
    [Route("api/bicycles")]
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

        [HttpGet("{id: int}", Name = "GetBicycles")]
        public async Task<ActionResult<BicycleDto>> Get (int id)
        {

            var bicycle = await _context.Bicycles.FirstOrDefaultAsync(x => x.Id == id);

            if (bicycle == null)
                return NotFound();

            var bicycleDto = _mapper.Map<BicycleDto>(bicycle);

            return bicycleDto;


        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BicycleCreationDto bicycleCreation)
        {
            var bicycle = _mapper.Map<Bicycle>(bicycleCreation);
            _context.Add(bicycle);
            await _context.SaveChangesAsync();

            var bicycleDto = _mapper.Map<BicycleDto>(bicycle);

            return new CreatedAtRouteResult("getBicycles", new {bicycleDto}, bicycleDto);


        }

        [HttpDelete("id: int")]
        public async Task<ActionResult<BicycleDto>> Delete(int id)
        {
            var exists = await _context.Bicycles.AnyAsync(x => x.Id == id);
            if (! exists)
                return NotFound();

            _context.Remove(new Bicycle() {Id = id});
           await _context.SaveChangesAsync();
           return NoContent();

        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody]BicycleCreationDto bicycleCreationDto)
        {
            var bicycle = _mapper.Map<BicycleDto>(bicycleCreationDto);
            bicycle.Id = id;
            _context.Entry(bicycle).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return NoContent();



        }




       
    }
}
