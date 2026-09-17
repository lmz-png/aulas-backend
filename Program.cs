// teste
/* topico 1 - pol 
 * topico 2 - pls
 * topico 3 - add
 */
/* 4
// * 5
 */
//Console.WriteLine("seu pedido foi confirmado");

//save information
//1. variaveis (caixas que guardam informacao)
// TIPO NOME_DA_VARIAVEL = VALOR;
//using System.Security.Authentication;

//int age = 30;
////int - interger (numeros inteiros)
////double/float - numeros quebrados (float)
////string - textos
//string name = "Lucas";
//float sales = 20;
//float promocao = 30;
//double promo = 10.20;
//age = 27;
//int height_weight = 180;
////Console.WriteLine(age);
////Console.WriteLine(name);
////constantes
// */
//const double PI = 3.14159;
////Console.WriteLine(PI);
//var preco = 18.25; // C# ja identifica que é double (valores quebrados)
//char InicialDoNome = 'L';
//Console.WriteLine("Por favor\nDigite seu nome");
//string nomeUsuario = Console.ReadLine(); //ler texto digitado
//Console.WriteLine("informe a idade");
//int idadeUsuario = int.Parse(Console.ReadLine());
//Console.WriteLine("Boa Noite " + nomeUsuario + "! \nVocê tem " + idadeUsuario + " anos.");
//Console.WriteLine($"confirmado, {nomeUsuario}!\n Você tem {idadeUsuario} anos.");

//operacoes aritimeticas
//int soma = 10 + 22;
//int subtracao = 89 - 20;
//int multiplicacao = 20 * 5;
//int divisao = 100 / 5;
////resto da divisao - recebeo restante da operacao
//int modulo = 10 % 3;
//Console.WriteLine(soma);
//Console.WriteLine(subtracao);
//Console.WriteLine(multiplicacao);
//Console.WriteLine(divisao);
//Console.WriteLine(modulo);

//Console.WriteLine("oi to the world!");
//int idade = 20;
//int soma = 10 + idade;
//Console.WriteLine(soma);
//int multi = soma * idade;
//Console.WriteLine(multi);

//string nome = "Paula";
//Console.WriteLine($"Olá, {nome}! Seja bem vinde.");
//int valor = 50;
//int result = valor * 2;
//Console.WriteLine(result);
//Console.WriteLine("escolha um número para calcular a média");
//double A = double.Parse(Console.ReadLine());
//Console.WriteLine("escolha um número para calcular a média");
//double B = double.Parse(Console.ReadLine());
//Console.WriteLine("escolha um número para calcular a média");
//double C = double.Parse(Console.ReadLine());
//double media = (A + B + C) / 3;
//Console.WriteLine(media);
//Console.WriteLine("Por favor\nDigite seu nome");
//string nomeUsuario2 = Console.ReadLine();
//Console.WriteLine("Informe sua idade");
//string idadeUsuario2 = Console.ReadLine();
//Console.WriteLine("Qual sua cidade?");
//string cidadeUsuario2 = Console.ReadLine();
//Console.WriteLine($"Confirmado, {nomeUsuario2}!\nVocê tem {idadeUsuario2} anos.\nVocê fala de {cidadeUsuario2}");

//int X = 20;
//int Y = 30;
////bool armazena true or false 01

//bool resultado2 = X < Y;
//Console.WriteLine(resultado2);

//strings - textos - ""
//aritimeticos - + * / 
//comparacao == >= =

//lista 1 avançados
//Console.WriteLine("Informe sua idade: ");
//int idadeVotar = int.Parse(Console.ReadLine()); //Parse converte texto'string' em numero'int'
//if (idadeVotar >= 16)
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}
//Console.WriteLine("temperatura 28 é");
//int temperatura = 28;
//if (temperatura > 25 && temperatura < 30) // && = 'e'   || = 'ou'
//{
//    Console.WriteLine("true");
//}
//else
//{  
//    Console.WriteLine("false");
//}

//bool temCartao = true;
//double compra = 50.0;
//if (temCartao == true || compra > 100) ;
//{
//    Console.WriteLine("Tem Desconto!");
//}
//if (temCartao || compra > 100) ;
//{
//    Console.WriteLine("Tem Desconto!");
//}

//nomenclatura
//Variavaies - camelCase (primeira palavra minusculo, as demais em maiusculo)

/////* valor que nao poder alterado
////int studentAge = 15;
//////snake case (python
//////student_age

//////metodos, classes - PascalCase
////Console.WriteLine();

////// operadores lógicas (unir perguntas)
////bool L = true;
////bool M = false;
////bool N = false;
//////&& - e (true se as duas condicoes forem verdadeiras)
////// false se um dos lados for falso
////bool resultado = L && M;
////Console.WriteLine(resultado);

//////operadores logicos e condicionais
////// || - ou
////// se um dos lados for verdade - retorne true
////resultado = L || N ;
////Console.WriteLine(resultado);
////// ! - negação (inverte true e false)
////resultado = !M;
////Console.WriteLine(resultado);

//// condicionais
////tomar uma ação exemplo: se fulano é maior de idade
////young, adult or old

//using static System.Runtime.InteropServices.JavaScript.JSType;

/////* valor que nao poder alterado
//Console.WriteLine("digite sua idade");
//int idade = int.Parse(Console.ReadLine());
//if (idade >= 18)

//{
//    Console.WriteLine("maior de idade");
//}
//else
//{
//    Console.WriteLine("menor de idade");
//}

//Console.WriteLine("digite um número");
//int numeroI = int.Parse(Console.ReadLine());
//if (numeroI > 0)

//{
//    Console.WriteLine("O número é positivo.");
//}
//else if (numeroI < 0)
//{
//    Console.WriteLine("O número é negativo.");
//}
//else
//{
//    Console.WriteLine("O número é zero.");
//}
//Console.WriteLine("Nota do Aluno.");
//double notaAluno = double.Parse(Console.ReadLine());
//if (notaAluno >= 7.0)
//{
//    Console.WriteLine("Aprovado.");
//}
//else
//{
//    Console.WriteLine("Reprovado");
//}


/////* valor que nao poder alterado
//Console.WriteLine("digite sua idade");
//int age = int.Parse(Console.ReadLine());
//if (age >= 60)

//{
//    Console.WriteLine("parabéns, Idoso");
//}
//else if (age >= 18)
//{
//    Console.WriteLine("parabéns, Adulto");
//}
//else if (age >= 14)
//{
//    Console.WriteLine("parabéns, Adolescente");
//}
//else
//{
//    Console.WriteLine("parabéns, Criança");
//}

//bool tarefaConcluida = true;

//if (tarefaConcluida = true)
//{
//    Console.WriteLine("A tarefa foi finalizada com sucesso!");
//}
//else
//{
//    Console.WriteLine("A tarefa está pendente!");
//}

//Console.WriteLine("digite sua nota");
//int nota1 = int.Parse(Console.ReadLine());
//if (nota1 >= 0 && nota1 <= 10)
//{
//    Console.WriteLine("nota válido");
//}
//else
//{
//    Console.WriteLine("nota inválido");
//}
//int saldo = 2;
//if (saldo >= 1)
//{
//    Console.WriteLine("seu saldo está positivo");
//}
//else if (saldo < 0)
//{
//    Console.WriteLine("seu saldo está negativo");
//}
//else
//{
//    Console.WriteLine("seu saldo está zerado");
//}


//bool tarefaConcluida = 

//// operador ternário (if/else)
//int idadeAluno = 18;
//string mensagem;
//if (idadeAluno > 17)
//{
//    mensagem = "Maior de idade";
//}
//else
//{
//    mensagem = "Menor de idade";
//}
//mensagem = (idadeAluno > 17) ? "Maior de idade" : "Menor de idade";
//Console.WriteLine(mensagem);
// estruturas condicionais (if/else)
/// estruturas de repetiçao
////
// while (enquanto> condiçao for verdade {faz algo}
//peço uma senha, enquanto a senha esiver errada, pergunto novamente
using static System.Runtime.InteropServices.JavaScript.JSType;

/// estruturas de repetiçao
Console.WriteLine("Digite a senha: ");
string senha = Console.ReadLine();
//enquanto a senha for diferente de vini
while (senha != "lucas123")
{
    Console.WriteLine("senha incorreta :(");
    Console.WriteLine("Digite a senha: ");
    senha = Console.ReadLine();
}
Random sorteio = new Random();
int numeroSecreto = sorteio.Next(1, 101);
Console.WriteLine(numeroSecreto);
// do/while
//  for
double salarioMensal = 4445;
bool possuiRestricao;

