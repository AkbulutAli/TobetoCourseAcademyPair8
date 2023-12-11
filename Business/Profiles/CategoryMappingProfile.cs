using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
    {
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
        CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();
        CreateMap<Category, GetListCategoryResponse>().ReverseMap();
        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();
        CreateMap<Category, DeleteCategoryRequest>().ReverseMap();

    }
       
    }
}
