using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lensaku.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            /*CreateMap<UserViewModel, User>()
                .ForMember(g => g.UserName, map => map.MapFrom(vm => vm.UserName))
                .ForMember(g => g.Password, map => map.MapFrom(vm => vm.Password))
                .ForMember(g => g.UserIn, map => map.MapFrom(vm => vm.User.UserIn))
                .ForMember(g => g.UserUp, map => map.MapFrom(vm => vm.User.UserUp))
                .ForMember(g => g.DateIn, map => map.MapFrom(vm => vm.User.DateIn))
                .ForMember(g => g.DateUp, map => map.MapFrom(vm => vm.User.DateUp));*/
        }
    }
}