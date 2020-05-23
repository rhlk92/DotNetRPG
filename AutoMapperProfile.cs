using AutoMapper;
using DotNetRPG.Dtos.Character;
using DotNetRPG.Models;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();            
            CreateMap<AddCharacterDto, Character>();
        }   
    }
}