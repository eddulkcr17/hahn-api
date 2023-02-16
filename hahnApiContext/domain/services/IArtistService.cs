using domain.values_objects;
using domain.entities;
namespace domain.services;

public interface IArtistService
{
  ArtistSalesVO create(CompleteArtistEntity completeArtist);
}
