using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {

            CreateMap<Children, ChildrenDTO>()             
                .ReverseMap();


            CreateMap<Parent, ParentDTO>()
            .ForMember(dest => dest.Min, opt => opt.MapFrom(src => src.Min))
            .ForMember(dest => dest.Hospital, opt => opt.MapFrom(src => src.Hospital)).ReverseMap();

        }
    }
}
