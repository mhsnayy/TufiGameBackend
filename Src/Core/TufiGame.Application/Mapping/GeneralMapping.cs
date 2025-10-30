using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TufiGame.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.User, DTOs.UserDTO.UserViewDto>().ReverseMap();//ForMember() kullanabiliriz.
        }
    }
}
