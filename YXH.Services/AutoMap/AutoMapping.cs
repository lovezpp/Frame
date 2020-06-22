using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YXH.Entities.Entity;
using YXH.Services.Dtos;

namespace YXH.Services.AutoMap
{
    public partial class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<EntityMetadata, EntityMetadataDto>()
            .ForAllMembers(p => p.ExplicitExpansion());

            CreateMap<EntityMetadataDto, EntityMetadata>()
           .ForAllMembers(p => p.ExplicitExpansion());

            CreateMap<Schedule, ScheduleDto>()
                .ForAllMembers(p => p.ExplicitExpansion());
            CreateMap<ScheduleDto, Schedule>()
                .ForAllMembers(p => p.ExplicitExpansion());

            ConfigureMappingCustom();
        }
    }
}
