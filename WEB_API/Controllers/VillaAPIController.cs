using Microsoft.AspNetCore.Mvc;
using WEB_API.Data;
using WEB_API.Models;
using WEB_API.Models.Dto;

namespace WEB_API.Controllers
{
    [ApiController]
    //[Route("api/VillaAPI")]
    [Route("api/[controller]")]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.VillaList;
        }

        [HttpGet("{id:int}")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.VillaList.FirstOrDefault(u => u.Id == id);
        }
    }
}
