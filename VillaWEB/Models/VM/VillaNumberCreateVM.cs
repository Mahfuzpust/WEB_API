﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using VillaWEB.Models.Dto;

namespace VillaWEB.Models.VM
{
    public class VillaNumberCreateVM
    {
       public VillaNumberCreateVM()
       {
            VillaNumber = new VillaNumberCreateDTO();
       }
        public VillaNumberCreateDTO VillaNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}

