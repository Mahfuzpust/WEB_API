using WEB_API.Models.Dto;

namespace WEB_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO{ Id=1, Name="Mahfuz" },
            new VillaDTO{ Id=2, Name="Khan" },
            new VillaDTO{ Id=3, Name="Raj"}
        };
    }
}
