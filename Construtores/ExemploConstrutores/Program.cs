using ExemploConstrutores.Models;

class Program
{
    public delegate void Operação(int x, int y);

    public static void Main(string[] args)
    {

        Matematica m = new Matematica(10, 20);
        m.Somar();

        /* //multi cast delegate
        Operação op = new Operação(Calculadora.Somar);
        op += Calculadora.Subtrair;
        op.Invoke(10, 10); */

        /* //delegate
        Operação op = new Operação(Calculadora.Somar);
        //outra forma de instanciar
        // Operação op = Calculadora.Somar; 

        op.Invoke(10, 10);
        //outra forma de invocar
        //op(10, 10); */



        /* //constante
        const double pi = 3.14;
        System.Console.WriteLine(pi); */

        /* //propriedades
        Data data = new Data();

        data.Mes = 12;
        data.ApresentarMes(); */

        /* //getters e setters
        Data data = new Data();
        data.SetMes(2);

        data.Mes = 12;
        System.Console.WriteLine(data.Mes);

        data.ApresentarMes(); */

        /* //Chamando o construtor da herança
        Aluno a1 = new Aluno("Cleyton", "Ferreira", "programação"); */

        /* //construtor privado
        Log log = Log.GetInstance();
        log.PropriedadeLog = "Teste Instância";

        Log log2 = Log.GetInstance();
        System.Console.WriteLine(log2.PropriedadeLog); */

        /* //construtor padrão e construtor com parâmetros
        Pessoa p1 = new Pessoa("Cleyton", "Ferreira");
        p1.Apresentar(); */
    }
}


