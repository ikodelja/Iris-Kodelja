using AutoMapper;
using KingICT.Academy.Messaging.Student;
using KingICT.Academy.Model;

namespace KingICT.Academy.Service.Mapping
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}
