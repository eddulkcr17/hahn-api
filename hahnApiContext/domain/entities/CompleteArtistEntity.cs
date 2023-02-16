namespace domain.entities;

public record CompleteArtistEntity
{
   public int Id {get; set;}
  public string ArtistName {get;set;}
  public string DisckName {get;set;}
  public int Publication {get; set;}
  public string Audit{ get; set;}
}
