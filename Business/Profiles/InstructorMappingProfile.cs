using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class InstructorMappingProfile : Profile // AutoMapper Profile class'ını inherit eder.
    {
        public InstructorMappingProfile()
        {
            // Profile class'ının constructorında bir CreateMap mevcuttur.
            // ReverseMap --> iki yönlü dönüşebilmesi için.

            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();
            CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
        }
        // Bu aşamadan sonra dependency.injection configurasyonlarını yapmamız lazım.
        // şimdilik gidip webApi içerisinde program.cs te yapıyoruz.
    }

}
