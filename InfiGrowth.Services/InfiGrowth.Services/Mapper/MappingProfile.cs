﻿using AutoMapper;
using InfiGrowth.Entity.Manage;
using dto = InfiGrowth.Models.Dto;
using model = InfiGrowth.Models.Models;

namespace InfiGrowth.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<InfiGrowth.Models.Models.CustomersRequestModel, Customers>();
            CreateMap<Customers, InfiGrowth.Models.Models.CustomersRequestModel>();

            CreateMap<InfiGrowth.Models.Models.CustomersResponseModel, Customers>();
            CreateMap<Customers, InfiGrowth.Models.Models.CustomersResponseModel>();

            CreateMap<InfiGrowth.Models.Models.ProductsResponseModel, Products>();
            CreateMap<Products, InfiGrowth.Models.Models.ProductsResponseModel>();

            CreateMap<InfiGrowth.Models.Models.ProductRequestModel, Products>();
            CreateMap<Products, InfiGrowth.Models.Models.ProductRequestModel>();
        }
    }
}
