using WEB_API.Models.Dto;

namespace WEB_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO{ Id=1, Name="Mahfuz", sqft=300, Occupancy = 400 },
            new VillaDTO{ Id=2, Name="Khan", sqft=500, Occupancy = 600  }
        };
    }
}
