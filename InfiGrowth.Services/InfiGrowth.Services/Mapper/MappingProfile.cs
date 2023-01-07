using AutoMapper;
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

            CreateMap<InfiGrowth.Models.Models.CategoriesRequestModel, Categories>();
            CreateMap<Categories, InfiGrowth.Models.Models.CategoriesRequestModel>();

            CreateMap<InfiGrowth.Models.Models.CategoriesResponseModel, Categories>();
            CreateMap<Categories, InfiGrowth.Models.Models.CategoriesResponseModel>();

            CreateMap<InfiGrowth.Models.Models.DeliveriesResponseModel, Deliveries>();
            CreateMap<Deliveries, InfiGrowth.Models.Models.DeliveriesResponseModel>();

            CreateMap<InfiGrowth.Models.Models.DeliveriesRequestModel, Deliveries>();
            CreateMap<Deliveries, InfiGrowth.Models.Models.DeliveriesRequestModel>();
        }
    }
}
