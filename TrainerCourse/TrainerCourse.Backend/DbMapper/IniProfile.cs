using AutoMapper;
using TrainerCourse.Backend.DTO;
using TrainerCourse.Backend.Models;

namespace TrainerCourse.Backend.DbMapper
{
    public class IniProfile : Profile
    {
        public IniProfile()
        {
            // Course Mapping
            CreateMap<Course, CourseDTO>()
                .ForMember(dest => dest.Trainer, opt => opt.MapFrom(src => src.Trainer));

            CreateMap<CourseAddDTO, Course>();
            CreateMap<Course, CourseAddDTO>();

            // Instructor Mapping
            CreateMap<Trainer, TrainerDTO>();
            CreateMap<TrainerDTO, Trainer>();

            CreateMap<Trainer, TrainerAddDTO>();
            CreateMap<TrainerAddDTO, Trainer>();
        }
    }
}
