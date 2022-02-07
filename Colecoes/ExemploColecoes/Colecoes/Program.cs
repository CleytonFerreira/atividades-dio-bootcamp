using Colecoes.Helper;

//LINQ
int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

System.Console.WriteLine($"Soma: {soma}");
System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");



/* //valores máximo, mínimo e médio com LINQ
var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var media = arrayNumeros.Average();

System.Console.WriteLine($"Mínimo: {minimo}");
System.Console.WriteLine($"Máximo: {maximo}");
System.Console.WriteLine($"Mádia: {media}"); */




/* //obtendo e ordenando valores com LINQ
var NumerosParesQuery =
    from num in arrayNumeros
    where num % 2 == 0
    orderby num
    select num;

var NumerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

System.Console.WriteLine("Números pares query: " + string.Join(", ", NumerosParesQuery));
System.Console.WriteLine("Números pares método: " + string.Join(", ", NumerosParesMetodo)); */

/* -------------------------------------------------------------------------------------------- */

/* //DICIONÀRIOS
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia"); */

/* //acessando valor de maneira segura
string valorProcurado = "SC";

if (estados.TryGetValue(valorProcurado, out string? estadoEncontrado))
{
    System.Console.WriteLine(estadoEncontrado);
}
else
{
    System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
} */

/* //removendo uma valor
foreach (KeyValuePair<string, string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
}

string valorProcurado = "BA";

System.Console.WriteLine($"Removendo o valor: {valorProcurado}");
estados.Remove(valorProcurado);

foreach (KeyValuePair<string, string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
} */


/* //atualizando um valor
string valorProcurado = "BA";

System.Console.WriteLine("Valor original:");
System.Console.WriteLine(estados[valorProcurado]);

estados[valorProcurado] = "BA - Teste atualização";

System.Console.WriteLine("Valor atualizado:");
System.Console.WriteLine(estados[valorProcurado]); */

/* //acessando um valor
string valorProcurado = "BA";
System.Console.WriteLine(estados[valorProcurado]); */

/* //percorrendo pares chave-valor do dicionário
foreach (KeyValuePair<string, string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
} */


/* -------------------------------------------------------------------------------------------- */

/* //COLEÇÔES ESPECÌFICAS

//pilha
Stack<string> pilhaLivros = new Stack<string>();

pilhaLivros.Push(".NET");
pilhaLivros.Push("DDD");
pilhaLivros.Push("Código Limpo");

System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

while (pilhaLivros.Count > 0)
{
    System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
    System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
}

System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}"); */


/* //fila
Queue<string> fila = new Queue<string>();

fila.Enqueue("Cleyton");
fila.Enqueue("Antonia");
fila.Enqueue("José");

System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

while (fila.Count > 0)
{
    System.Console.WriteLine($"Vez de: {fila.Peek()}.");
    System.Console.WriteLine($"{fila.Dequeue()} atendido.");
    System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

} */


/* -------------------------------------------------------------------------------------------- */
//COLEÇÔES GENÈRICAS(LISTAS)
/* OperacoesLista opLista = new OperacoesLista();
List<string> estados = new List<string> {"SP", "MG", "BA"};
string[] estadosArray = new string[2] { "SC", "MT" };

System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

opLista.ImprimirListaString(estados); */

/* //remoção de item da lista
System.Console.WriteLine("Removendo o elemento da lista");
estados.Remove("MG"); */

/* //adiciona no final da coleção
estados.AddRange(estadosArray); */

//adicionar elemento em um índice específico
//estados.Insert(1, "RJ");

//opLista.ImprimirListaString(estados);

/* //iterando elementos da lista com for
for (int i = 0; i < estados.Count; i++)
{
    System.Console.WriteLine($"índice {i}, valor: {estados[i]}");
} */

/* //iterando elementos da lista com foreach
foreach (var item in estados)
{
    System.Console.WriteLine(item);
} */

/* -------------------------------------------------------------------------------------------- */

//ARRAYS

/* OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10]; */

/* //convertendo um array 
string[] arrayString = op.ConverterParaArrayString(array); 

int valorProcurado = 8;

System.Console.WriteLine($"Capacidade total do array: {array.Length}"); */


//convertendo um array


/* //redimensionando array
System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
op.RedimensionarArray(ref array, array.Length * 2);
System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}"); */

/* //encontrando o índice de um valor
int indice = op.ObterIndice(array, valorProcurado);

if (indice > -1)
{
    System.Console.WriteLine("O índice do elemento {0} é {1}", valorProcurado, indice);
}
else
{
    System.Console.WriteLine("Valor não existente no array");
} */

/* //encontrando um elemento no array
int valorAchado = op.ObterValor(array, valorProcurado);

if (valorAchado > 0)
{
    System.Console.WriteLine("Encontrei o valor");
}
else
{
    System.Console.WriteLine("Não encontrei o valor");
} */


/* //vereificando todos os elementos do array
bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

if (todosMaiorQue)
{
    System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
}
else
{
    System.Console.WriteLine("Existem valores que são maiores do que {0}", valorProcurado);
} */

/* //verificando elemento existente
bool existe = op.Existe(array, valorProcurado);

if (existe)
{
    System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
}
else
{
    System.Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
} */

/* //Cópia de array
System.Console.WriteLine("Array antes da cópia");
op.ImprimirArray(arrayCopia);

op.Copiar(ref array, ref arrayCopia);
System.Console.WriteLine("Array após a cópia");

op.ImprimirArray(arrayCopia); */

// System.Console.WriteLine("Array original");
// op.ImprimirArray(array);

//Classe Array
//op.Ordenar(ref array);

// System.Console.WriteLine("Array ordenado");
// op.ImprimirArray(array);

/* 
//bubble sort
OperacoesArray op = new OperacoesArray();
int[] array = new int[5] { 6, 3, 8, 1, 9 };

System.Console.WriteLine("Array original");
op.ImprimirArray(array);

op.OrdenarBubbleSort(ref array);

System.Console.WriteLine("Array ordenado");
op.ImprimirArray(array); */

/*matriz 
int[,] matriz = new int[4, 2]
{
    {8, 8},
    {10, 20},
    {50, 100},
    {90, 200}
};

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        System.Console.WriteLine(matriz[i, j]);
    }
} */

/* array
int[] arrayInteiros = new int [3];
arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

System.Console.WriteLine("Percorrendo array pelo for");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    System.Console.WriteLine(arrayInteiros[i]);
}

System.Console.WriteLine("Percorrendo array pelo foreach");
foreach (int item in arrayInteiros)
{
    System.Console.WriteLine(item);
} */