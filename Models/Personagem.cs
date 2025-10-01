using System;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;


namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int PontosVida { get; set; }

        public int Forca { get; set; }

        public int Defesa { get; set; }

        public int Inteligencia { get; set; }

        public ClasseEnum Classe { get; set; }
<<<<<<< HEAD
        public byte[]? FotoPersonagem { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
=======

        public byte[]? FotoPersonagem {get ; set;}

        public int? UsuarioId {get; set;}

        public Usuario? Usuario {get; set;}
>>>>>>> 162d5722479230e1effdebfa2dd54f8a27124703
    }
    

}