using application.entities;
using domain.values_objects;

namespace application.services;

public interface IArtistService
{ 
  ArtistSalesVO create(ArtistEntity artist);
  }
