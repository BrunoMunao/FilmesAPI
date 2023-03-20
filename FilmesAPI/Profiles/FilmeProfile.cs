using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateFilmeDto, Cinema>();
            CreateMap<UpdateFilmeDto, Cinema>();
            CreateMap<Cinema, UpdateFilmeDto>();
            CreateMap<Cinema, ReadFilmeDto>();
        }
    }
}
