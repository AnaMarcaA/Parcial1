using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_AnaMarcaAngola.Models
{
    public class Producto
    {
        [Key]
        public float ProductoID { get; set; }
        [Required]
        public float Description { get; set; }
        [Required]
        public float Price { get; set; }
        public float LastBuy { get; set; }
    }
}