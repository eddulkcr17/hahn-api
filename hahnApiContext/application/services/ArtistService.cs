
using DomainService = domain.services;

using domain.entities;
using domain.values_objects;
using application.entities;
using AutoMapper;

namespace application.services;

public class ArtistService : IArtistService
{

private readonly IMapper _mapper;
private readonly DomainService.IArtistService artistDomainService;

public ArtistService(DomainService.IArtistService artistDomainService, IMapper mapper)
    {
        this.artistDomainService = artistDomainService;
        _mapper = mapper;
    }
  public ArtistSalesVO create(ArtistEntity artist)
  {
     artist = artist with { Id = Guid.NewGuid().ToString() };
        CompleteArtistEntity artistaCompleto = _mapper.Map<CompleteArtistEntity>(artist);
        ArtistSalesVO artistaVenta = this.artistDomainService.create(artistaCompleto);
        return artistaVenta;
  }
}
