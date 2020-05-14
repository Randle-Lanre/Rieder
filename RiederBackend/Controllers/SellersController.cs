using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RiederBackend.Dtos;

namespace RiederBackend.Controllers
{
    [ApiController]
    [Route("api/sellers")]
    public class SellersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<SellersController> _logger;

        public SellersController( IMapper mapper, ApplicationDbContext dbContext, ILogger<SellersController> logger)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _logger = logger;
        }

        public Task<ActionResult<SellerDto>> Get()
        {

        }


    }
}
