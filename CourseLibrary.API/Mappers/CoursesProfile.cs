using AutoMapper;
using CourseLibrary.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Mappers
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CourseDto>();
            CreateMap<CourseForCreationDto, Entities.Course>();
            CreateMap<CourseForUpdateDto, Entities.Course>();
            CreateMap<Entities.Course, CourseForUpdateDto>();
        }
    }
}
