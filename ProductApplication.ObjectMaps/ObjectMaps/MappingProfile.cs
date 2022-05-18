using AutoMapper;
using ProductApplication.DatabaseEntities.Models;
using ProductApplication.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.ObjectMaps.ObjectMaps
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Product, ProductData>();
           
        }
    }
}
