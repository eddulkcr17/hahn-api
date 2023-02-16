using api.dtos;
using application.entities;
using AutoMapper;
using domain.entities;

namespace api;


public class MappingProfile: Profile 
{
  public MappingProfile(){
    CreateMap<ArtistDto, ArtistEntity>();
    CreateMap<ArtistEntity, ArtistDto>();

    CreateMap<ArtistEntity, CompleteArtistEntity>();
    CreateMap<CompleteArtistEntity, ArtistEntity>();
  }
}
