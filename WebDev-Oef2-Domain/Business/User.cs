using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev_Oef2_Domain.Business
{
    public class User
    {
        private string _naam;
        private string _mail;

        public string Naam { get => _naam; set => _naam = value; }
        public string Mail { get => _mail; set => _mail = value; }

        
    }
}
