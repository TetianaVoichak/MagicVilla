﻿using System.ComponentModel.DataAnnotations;
namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaNumberCreateDTO
    {

        [Required] // error if the field is empty
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }

        [Required]
        public int VillaID { get; set; }

    }
}
