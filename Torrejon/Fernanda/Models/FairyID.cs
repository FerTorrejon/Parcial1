using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fernanda.Models
{
    public enum TypeWishes {Foco, Foca, Finca, Funda, Feo}
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24,ErrorMessage = "Entre 3 a 25 caracteres", MinimumLength = 3)]

        public TypeWishes wishes { get; set; }

        public string Telefono { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
    }
}