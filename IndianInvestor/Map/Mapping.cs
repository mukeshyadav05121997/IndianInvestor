using AutoMapper;
using IndianInvestor.Data;
using IndianInvestor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Map
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Admin, AdminMV>().ReverseMap();
        }
    }
}
