using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using api.dtos;
using domain.values_objects;
using application.entities;
using application.services;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistaController : ControllerBase
{

    private readonly IMapper _mapper;
    private readonly IArtistService artistService;

    public ArtistaController(IMapper mapper, IArtistService artistService)
    {
        _mapper = mapper;
        this.artistService = artistService;
    }

    [HttpPost]
    public ActionResult post(ArtistDto request)
    {
        ArtistSalesVO artista = this.artistService.create(_mapper.Map<ArtistEntity>(request));
        string json = JsonConvert.SerializeObject(artista, Formatting.Indented);
        return Ok(json);
    }
}
