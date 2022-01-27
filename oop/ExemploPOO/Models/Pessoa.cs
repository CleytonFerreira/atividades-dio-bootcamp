using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        
        //virtual informa que o método pode ser sonbrescrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}