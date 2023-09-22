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
       public ActionResult<IEnumerable<reguladorDto>> GetReguladors()
       {
            return Ok(DelcoRemyStore.reguladorsList);
       }

        [HttpGet ("id:int")]
        public ActionResult<reguladorDto> GetRegulador(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var regulador = DelcoRemyStore.reguladorsList.FirstOrDefault(x => x.Id == id);
            if (regulador == null)
            {
                return NotFound();
            }
            return Ok(regulador);
        }
     
    }
}