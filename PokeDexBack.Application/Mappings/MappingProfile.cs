
using AutoMapper;
using PokeDexBack.Application.Features.Moves.Queries.GetMoves;
using PokeDexBack.Domain.Models;

namespace PokeDexBack.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Result, ResponseVm>()
                .ForMember(dest => dest.Count, src => src.MapFrom(s => s.Count))
                .ForMember(dest => dest.Next, src => src.MapFrom(s => s.Next))
                .ForMember(dest => dest.Previous, src => src.MapFrom(s => s.Previous))
                .ForMember(dest => dest.Moves, src => src.MapFrom(s => s.Results))
                .ReverseMap();
        }
    }
}
