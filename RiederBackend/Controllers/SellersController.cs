using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RiederBackend.Dtos;
using RiederBackend.Entities;

namespace RiederBackend.Controllers
{
    [ApiController]
    [Route("api/sellers")]
    public class SellersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SellersController> _logger;

        public SellersController( IMapper mapper, ApplicationDbContext context, ILogger<SellersController> logger)
        {
            _mapper = mapper;
            _context = context;
            _logger = logger;
        }


        [HttpGet("{id: int}", Name = "getSellers")]
        public async Task<ActionResult<SellerDto>> Get(int id)
        {
            var seller =  await _context.Sellers.FirstOrDefaultAsync(x => x.Id == id);

            if (seller == null)
            {
                _logger.Log(LogLevel.Warning, "could not find seller");
                return NotFound();
            }

            var sellerDto = _mapper.Map<SellerDto>(seller);

            return sellerDto;


        }

        [HttpPost]

        public async Task<ActionResult> Post([FromForm] SellerCreationDto sellerCreation )
        {
            var seller = _mapper.Map<Seller>(sellerCreation);
            _context.Add(seller);
            await _context.SaveChangesAsync();

            var sellerDto = _mapper.Map<SellerDto>(seller);

            return new CreatedAtRouteResult("getSellers", new {sellerDto}, sellerDto );



        }

        [HttpDelete]
        public async Task<ActionResult<SellerDto>> Delete(int id)
        {
            var sellerExists = await _context.Sellers.AnyAsync(x => x.Id == id);

            if (!sellerExists)
                return NotFound();

            _context.Remove(new Seller() { Id = id });
            await _context.SaveChangesAsync();
            return NoContent();





        }

        
        
    }
}
