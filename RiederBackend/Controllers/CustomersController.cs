using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiederBackend.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Controllers
{
    [ApiController]
    [Route("Api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CustomersController(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;


        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustomerDto>> Get(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;



        }






        

    }
}
