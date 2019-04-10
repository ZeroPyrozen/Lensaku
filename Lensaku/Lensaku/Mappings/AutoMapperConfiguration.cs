using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lensaku.Mappings
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration config;
        public static void Configure()
        {
            config = new MapperConfiguration(x => {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}