using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeraGhar.Models
{
   public class ServiceContactDetailModel
   {
       public int Type { get; set; } = 0;
        public int Id { get; set; } = 0;
        public string Services { get; set; } = "";
       public string Name { get; set; } = "";
       public string Address { get; set; } = "";
       public string ContactDetails { get; set; } = "";
    }
}
