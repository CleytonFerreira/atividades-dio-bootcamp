namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public double Salario { get; set; }

        //COLOQUE A PALAVRA RESERVADA "SEALED" ANTES DE OVERRIDE PARA SELAR O MÈTODO
        public  override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. Sou um professor e ganho {Salario}");
        }
    }
}