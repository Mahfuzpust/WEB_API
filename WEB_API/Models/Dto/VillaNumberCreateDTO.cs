using System.ComponentModel.DataAnnotations;

namespace WEB_API.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillNo { get; set; }
        public string SpecialDetails { get; set; }
    }
}
