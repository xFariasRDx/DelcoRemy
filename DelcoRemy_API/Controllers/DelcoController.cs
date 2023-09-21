using DelcoRemy_API.Datas;
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
            return DelcoRemyStore.reguladorsList;
       }

        [HttpGet ("id:int")]
        public reguladorDto GetRegulador(int id)
        {
            return DelcoRemyStore.reguladorsList.FirstOrDefault(x => x.Id == id);
        }
    
    }
}