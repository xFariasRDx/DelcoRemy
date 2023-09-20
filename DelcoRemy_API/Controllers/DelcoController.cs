using DelcoRemy_API.Models;
using DelcoRemy_API.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DelcoRemy_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelcoController : ControllerBase
    {
        [HttpGet]
       public IEnumerable<reguladorDto> GetReguladors()
        {
            return new List<reguladorDto>
            {
                 new reguladorDto{Id=1, Name="AR123", Manufacturer="Delco Remy"},
                 new reguladorDto{Id=2,Name="AR456", Manufacturer="Delco Remy"},
                 new reguladorDto{Id=3,Name="AR789", Manufacturer="Delco Remy"}
            };
        } 
    }
}