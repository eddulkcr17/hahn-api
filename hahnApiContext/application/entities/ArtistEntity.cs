namespace application.entities;

public record ArtistEntity
{
  public string Id {get; set;} =string.Empty;
  public string ArtistName {get;set;} = string.Empty;
  public string DiskName { get; set; } = string.Empty; 
  public int Publication {get; set;} = 0;
}
