using AutoMapper;
using Pepper.Dto;
using Pepper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pepper.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}