using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        public static object Exercicio { get; private set; }

        static void Main(string[] args)
        {
                    programamedia();

                   // Exercicio1();

                    //Exercicio2();

                     //Exercicio04();

                    // exercicio5();

                    //exercicio6();

                  Console.ReadKey();
        }

        private static void exercicio6()
        {
            // Construa um algoritmo que converte temperatura de graus Celsius para Fahrenheit usando uma fórmula F = (C×95)+32

            // Solicita ao usuário a temperatura em Celsius

            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Calcula a temperatura em Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Exibe o resultado
            Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit}");
        }

        private static void exercicio5()
        {
            // Crie uma variável para o preço de um produto e aplique um desconto de 10 %.Mostre o valor final.
            // Definindo o preço do produto
           
            double precoOriginal = 100.00; // Exemplo: R$100,00
            double desconto = 0.10; // 10%

            // Calculando o preço com desconto
            double precoComDesconto = precoOriginal - (precoOriginal * desconto);

            // Exibindo o valor final
            Console.WriteLine("Preço original: R$ " + precoOriginal);
            Console.WriteLine("Preço com desconto: R$ " + precoComDesconto);
        }

        private static void Exercicio04()
        {
            // Definindo os valores da expressão
            double a = 2;
            double b = 3;
            double c = 42;
            double d = 1 - 5; // Isso é -4
            double dSquared = Math.Pow(d, 2); // Isso é 16

            // Calculando a expressão
            double result = a + (b * c / dSquared) + (b * c / d);

            // Exibindo o resultado
            Console.WriteLine("Resultado: " + result);
        }
    
    private static void Exercicio4()
         { 
            //Operações Aritméticas Calcular a média aritmética de três números inteiros

            // Declaração dos três números inteiros
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            // Cálculo da média aritmética
            double media = (num1 + num2 + num3) / 3.0;

            // Exibição do resultado
            Console.WriteLine("A média aritmética é: " + media);
            
            Console.ReadKey();
        }

        private static void Exercicio2()
        {
            //Crie uma constante para o valor de Pi(3.14159) e use-a para calcular a área de um círculo com raio
            //costante para o valor de PI
            const double PI = 3.14159;

            //solicita o raio ao usuario
            Console.WriteLine("digite o raio do circulo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            //calcula a area do circulo
            double area = PI *raio * raio;

            Console.WriteLine("a area do circulo é: " +area);

            Console.ReadKey();
        }

        private static void Exercicio1()
        {
            // Declarar três variáveis de tipos diferentes(inteiro, real e caractere) e atributos
            string nome, cargo;
            decimal dinheiro;


            Console.WriteLine("escreva seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" qual é o seu salario ");
            dinheiro = decimal.Parse (Console.ReadLine());

            Console.WriteLine("qual é seu cargo ");
            cargo = Console.ReadLine();

            Console.ReadKey();

        }

        private static void programamedia()
        {
            string Nome;
            decimal nota1, nota2, nota3, nota4, resultado;

            Console.WriteLine("digite seu nome: ");

            Nome = Console.ReadLine();

            Console.WriteLine(" Seja bem vindo " + Nome);

            Console.WriteLine(" digite as notas do aluno " + Nome);

            nota1 = decimal.Parse(Console.ReadLine());
            nota2 = decimal.Parse(Console.ReadLine());
            nota3 = decimal.Parse(Console.ReadLine());
            nota4 = decimal.Parse(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("a media é :" + resultado);






            Console.ReadKey();
        }
    }
}
