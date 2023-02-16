namespace domain.values_objects;

public record ArtistSalesVO(
  int Id,
  string ArtistName,
   string DisckName,
   int Publication,
   string Audit,
   decimal Sales
   );
