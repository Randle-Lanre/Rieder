using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RiederBackend.Dtos;
using RiederBackend.Entities;

namespace RiederBackend.Helpers
{
    public class AutomapperProfiles: Profile
    {
        public AutomapperProfiles()
        {

            CreateMap<Bicycle, BicycleDto>().ReverseMap();

            CreateMap<BicycleCreationDto, Bicycle>();



        }
    }
}
