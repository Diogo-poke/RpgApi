using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Arma
    {
         public int Id { get; set; }

        public string Nome { get; set; } 

        public int Dano { get; set; }

        public Personagem? Personagem
    }
}