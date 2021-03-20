using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parcial1_AnaMarcaAngola.Models
{
    public class DatoContext:DbContext
    {
        public DatoContext():base("DefaultConnection")
        {

        }
    }
}