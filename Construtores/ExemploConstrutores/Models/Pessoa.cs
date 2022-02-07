using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//construtor padrão e construtor com parâmetros
namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string? nome;
        private string? sobrenome;

        /* public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        } */

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor das classe Pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}.");
        }
    }
}