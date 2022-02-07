using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//readonly
namespace ExemploConstrutores.Models
{
    public class Pessoa02
    {
        private readonly string nome = "Cleyton";
        private readonly string sobrenome;

        public Pessoa02()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa02(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}.");
        }
    }
}