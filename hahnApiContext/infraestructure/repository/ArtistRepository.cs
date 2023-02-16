using domain.contracts;
using domain.entities;

namespace infraestructure.repository;

public class ArtistaRepository : IArtistaRepository
{
  public bool create(CompleteArtistEntity completeArtist)
  {
    Console.WriteLine(completeArtist.ToString());
    return true;
  }
}