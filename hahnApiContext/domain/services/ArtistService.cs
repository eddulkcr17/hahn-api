using domain.contracts;
using domain.entities;
using domain.values_objects;

namespace domain.services;

public class ArtistService : IArtistService
{
  private readonly IArtistaRepository artistRepository;

  public ArtistService(IArtistaRepository artistRepository)
  {
    this.artistRepository = artistRepository;
  }

  public ArtistSalesVO create(CompleteArtistEntity completeArtist)
  {
    completeArtist = completeArtist with { Audit = "Admin" };
    if (!this.artistRepository.create(completeArtist))
    {
      throw new Exception("No saved in the DB");
    }
    return new ArtistSalesVO(
      completeArtist.Id,
      completeArtist.ArtistName,
      completeArtist.DisckName,
      completeArtist.Publication,
      completeArtist.Audit,
      completeArtist.Publication * 2
    );
  }
}
