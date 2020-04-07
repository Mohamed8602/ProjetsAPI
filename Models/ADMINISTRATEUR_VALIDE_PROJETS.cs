using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetsAPI.Models
{
    public class ADMINISTRATEUR_VALIDE_PROJETS
    {
       
        public IEnumerable<PROJETS> projets { get; set; }
        public ADMINISTRATEUR AdminId{ get;set; }
} 
}