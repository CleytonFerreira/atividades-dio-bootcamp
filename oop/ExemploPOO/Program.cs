using System.IO;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using ExemploPOO.Helper;

/* //EXCLUINDO ARQUIVOS
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
var novoCaminhoArquivo = Path.Combine(caminho, "pasta teste 02", "arquivo-teste-stream.txt");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

FileHelper helper = new FileHelper();
helper.DeletarArquivo(caminhoArquivoTesteCopia); */

/* //COPIANDO ARQUIVOS
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
var novoCaminhoArquivo = Path.Combine(caminho, "pasta teste 02", "arquivo-teste-stream.txt");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

FileHelper helper = new FileHelper();
helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false); */

/* //MOVER ARQUIVOS
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var novoCaminhoArquivo = Path.Combine(caminho, "pasta teste 02", "arquivo-teste-stream.txt");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

FileHelper helper = new FileHelper();
helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo); */

/* //LENDO ARQUIVOS
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

FileHelper helper = new FileHelper();
helper.LerArquivoStream(caminhoArquivo); */

/* //ADICIONAR LINHAS AO ARQUIVO
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

FileHelper helper = new FileHelper();
helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao); */

/* //CRIAR TEXTO COM STREAM
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};

FileHelper helper = new FileHelper();
helper.CriarArquivoTextoStream(caminhoArquivo, listaString); */

/* //CRIANDO ARQUIVO DE TEXTO
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
FileHelper helper = new FileHelper();
helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo"); */

/* //DELETAR DIRETÒRIO
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 01");
FileHelper helper = new FileHelper();
helper.ApagarDiretorio(caminhoPathCombine, true); */

/* //CRIAR DIRETÒRIO (PATH COMBINE)
var caminho = "C:\\Trabalhando com arquivos";
var caminhoPathCombine = Path.Combine(caminho, "pasta teste 03",  "subpasta teste 03");
FileHelper helper = new FileHelper();

System.Console.WriteLine("Criando diretório " + caminhoPathCombine);
helper.CriarDiretorio(caminhoPathCombine);  */

/* //LISTAR ARQUIVOS
var caminho = "C:\\Trabalhando com arquivos";
FileHelper helper = new FileHelper();
helper.ListarArquivosDiretorios(caminho); */


/* //LISTAR DIRETÒRIOS
var caminho = "C:\\Trabalhando com arquivos";
FileHelper helper = new FileHelper();
helper.ListarDiretorios(caminho); */

/* //INTERFACE SEM IMPLEMENTAÇÃO DE MÉTODOS
ICalculadora calc = new Calculadora();
System.Console.WriteLine(calc.Somar(10, 20)); */

/* //CLASSE OBJECT
Computador comp = new Computador();

Console.WriteLine(comp.ToString()); */

/* //CLASSES ABSTRATAS
Corrente c = new Corrente();
c.creditar(100);

c.exibirSaldo(); */

/* //POLIMORFISMO EM TEMPO DE COMPILAÇÃO / SOBRECARGA DE MÉTODOS
Calculadora calc = new Calculadora();
System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 5));
System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 2, 8)); */

/* //POLIMORFISMO EM TEMPO DE EXECUÇÃO / SOBRESCRITA DE MÉTODOS
Aluno a2 = new Aluno();
a2.Nome = "Pedro";
a2.Idade = 20;
a2.Nota = 10;
a2.Apresentar(); */

/* //HERANÇA
Aluno a1 = new Aluno();
a1.Nome = "José";
a1.Idade = 32;

a1.Apresentar();

Professor pr1 = new Professor();
pr1.Nome = "João";
pr1.Idade = 50;
pr1.Salario = 8000;

pr1.Apresentar(); */

/* //ENCAPSULAMENTO
Retangulo r = new Retangulo();
r.DefinirMedidas(40, 20);

Console.WriteLine($"Área: {r.ObterArea()}"); */

/* 
//ABSTRAÇÃO
Pessoa p1 = new Pessoa();

p1.Nome = "Cleyton";
p1.Idade = 40;

p1.Apresentar(); 
*/