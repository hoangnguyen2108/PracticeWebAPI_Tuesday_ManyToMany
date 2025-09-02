using AutoMapper;
using PracticeWebAPI_Tuesday.DTO;
using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<StudentClass,StudentClassDTO>().ReverseMap();
            CreateMap<StudentClass,StudentDTO>().ReverseMap();
            CreateMap<EnrollmentSC,EnrollmentDTO>().ReverseMap();
            CreateMap<StudentClass,StudentCreateDTO>().ReverseMap();
        }
    }
}
