namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        //POLIMORFISMO EM TEMPO DE EXECUÇÃO OU SOBRESCRITA DE MÉTODOS 
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}.");
        }
    }
}