using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lensaku.Mappings
{
    public class AutoMapperService
    {
        public MapperConfiguration Configure(Profile ProfileName = null)
        {
            MapperConfiguration config = new MapperConfiguration(x => {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
            return config;
        }
    }
}