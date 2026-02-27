// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Runtime.Serialization;

/*

namespace InicioEstudo
{
       internal class Program
    {
        static void Main(string[] args)
        {

            sbyte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; // Unicode
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Marie Green";
            nome = "Joao"; // substituiu maria
            object obj1 = "Alex";
            object obj2 = 4.5;

            int t1 = int.MinValue;
            int t2 = int.MaxValue;
            sbyte t3 = sbyte.MinValue;
            decimal t4 = decimal.MaxValue;



            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

        }
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        /*
        char genero = 'F';
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";

        /*
        Console.Write("Bom dia");
        Console.Write("boa tarde");
        Console.WriteLine("-------------------------");
        Console.WriteLine(genero);
        Console.WriteLine(idade);
        Console.WriteLine(saldo);
        Console.WriteLine(nome);
        Console.WriteLine(saldo.ToString("F2"));
        Console.WriteLine(saldo.ToString("F4"));
        Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));
        

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //placeroders
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais.");//interpolação
        Console.WriteLine(nome + " tem " +  idade +" anos e tem saldo igual a "+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");//concatenação
        */

        // EXERCICO DE FIXAÇÃO
        /*
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1} cujo preço é ${ preco1.ToString("F2")}");
        Console.WriteLine($"{produto2} cujo preço é ${ preco2.ToString("F2")}");
        Console.WriteLine();
        Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: {genero}");
        Console.WriteLine();
        Console.WriteLine($"Medidas com oito casas decimais: {medida.ToString("F8")} ");
        Console.WriteLine($"Arredondando (tres casas decimais): {medida.ToString("F3")}");
        Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        */


        // AULA DE OPERADORES DE ATRIBUIÇÃO

        // =, +=, -=, *= ...

        // TAMBEM PODE SER USADO COM STRING ex:

        /*string s = "ABC";
        Console.WriteLine(s);

        s += "DEF";
        Console.WriteLine(s);
        */

        // OPERADORES DE ATRIBUIÇÃO ex: ++ , -- ...

        /*
        int a = 10;
        int b = ++a;
        
        Console.WriteLine(a);
        Console.WriteLine(b);

        int e = 10;
        e--;
        Console.WriteLine(e);
        */

        // NOVA AULA - CONVERSAO IMPLICITA E EXPLICITA

        /*
         float x = 4.5f;

         double y = x; // conversão implicita /// quando o tipo de destino tem uma capacidade maior que o tipo de origem, a conversão é feita automaticamente.
         Console.WriteLine(y);

         double a;
         float b;

         a= 5.1;
         b = a; // conversão explicita /// quando o tipo de destino tem uma capacidade menor que o tipo de origem, é necessário fazer uma conversão explícita, utilizando um cast.   
         b = (float)a; // cast


         int a = 5;
         int b = 2;
= 1.0
         double resultado = a / b; // resultado é 2, porque a divisão entre dois inteiros resulta em um inteiro. O resultado é convertido para double, mas o valor já foi truncado.
         Console.WriteLine(resultado);
         double resultado2 = (double)a / b; // resultado é 2.5, porque o cast para double é feito antes da divisão, permitindo que a divisão seja realizada com precisão.
         Console.WriteLine(resultado2);

             */

        // OPERADORES ARITMETICOS

        /*

        int n1 = 3 + 4 * 2; // a multiplicação tem precedência sobre a adição, então o resultado é 3 + (4 * 2) = 3 + 8 = 11
        int n2 = (3 + 4) * 2; // os parênteses alteram a ordem de avaliação, então o resultado é (3 + 4) * 2 = 7 * 2 = 14
        int n3 = 17 % 3; // o operador de módulo (%) retorna o resto da divisão de 17 por 3, que é 2, porque 17 dividido por 3 é igual a 5 com um resto de 2.
        int n4 = 10 / 8;

        double a = 1.0, b = -3.0, c =-4.0;

        double delta = b * b - 4.0 * a * c; // pode ser usado tambem no lugar de b*b o Math.Pow(b,2.0) e pode ser trocado os valores.

        double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); 


        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(delta);
        Console.WriteLine(x1);
        
         */




        //ENTRADA DE DADOS EM C#


        /*O comando para poder ser lifo os dados digitados pelo usuarios é Console.ReadLine(), ele lê a linha digitada pelo usuário e retorna uma string. 
        Se for necessário converter essa string para outro tipo de dado, como int ou double, é possível usar os métodos de conversão, como int.Parse() ou double.Parse().*/

        /*
        string frase = Console.ReadLine();
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();

        

        string[] v = Console.ReadLine().Split(' ');
        string a = v[0];
        string b = v[1];
        string c = v[2];



        Console.WriteLine("Você digitou: ");
        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        */

        // SEGUNDA PARTE 
        /*
        int n1 = int.Parse(Console.ReadLine()); // o método int.Parse() é usado para converter a string lida pelo Console.ReadLine() em um inteiro. Se o usuário digitar algo que não pode ser convertido para um inteiro, como "abc", isso resultará em uma exceção.
        char ch = char.Parse(Console.ReadLine()); // para ler um caractere, você pode usar Console.ReadLine() para ler a linha inteira e depois acessar o primeiro caractere usando [0]. Isso assume que o usuário digitará pelo menos um caractere.
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        string [] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        int idade = int.Parse(vet[1]);
        char sexo = char.Parse(vet[2]);
        double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);




        Console.WriteLine("Voce digitou: ");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(sexo);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        */
        //EXERCICIO DE FIXAÇÃO

        /*

        string nomeCompleto = Console.ReadLine();
        int quartos = int.Parse(Console.ReadLine());
        double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        string [] vet  = Console.ReadLine().Split(' ');
        string ultimoNome = vet[0];
        int idade = int.Parse(vet[1]);
        double salario = double.Parse(vet[2], CultureInfo.InvariantCulture);


        Console.WriteLine("Entre com seu nome completo");
        Console.WriteLine(nomeCompleto);
        Console.WriteLine("Quantos quartos tem na sua casa?");
        Console.WriteLine(quartos);
        Console.WriteLine("Entre com o preço de um produto");
        Console.WriteLine(produto);
        Console.WriteLine("Entre com seu ultimo nome, idade e salario (mesma linha)");
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idade);
        Console.WriteLine(salario.ToString("F3", CultureInfo.InvariantCulture));

        */

        // EXERCICIOS DE FIXACAO - EXERCICIO RESOLVIDO - ESTRUTURA SEQUENCIAL

        /* 1

        Console.WriteLine("Entre com o primeiro numero desejado: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o segundo numero para somar: ");
        int n2 = int.Parse(Console.ReadLine());
        int soma = n1 + n2;
        Console.WriteLine($"Esse é o resultado: {soma}");
        */

        //**************************************************

        /* 2 Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
           casas decimais conforme exemplos.
           Fórmula da área: area = π . raio2
           Considere o valor de π = 3.14159
        
        double valCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double pi = 3.14159;
        double area = pi * valCirculo * valCirculo ;

        Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
        */

        //*********************************************************

        /*3 Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        
        
        string[] vet = Console.ReadLine().Split(' ');
        int A = int.Parse(vet[0]);
        int B = int.Parse(vet[1]);
        int C = int.Parse(vet[2]);
        int D = int.Parse(vet[3]);

        int diferenca = (A * B - C * D);

        Console.WriteLine("DIFERENÇA = " + diferenca);
        */

        //********************************************


        // 4 * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        // hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
        //decimais.
        /*
       int a , b ;
       double valorHora, pay;


       a = int.Parse(Console.ReadLine());
       b = int.Parse(Console.ReadLine());
       valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       pay = b * valorHora;

       Console.WriteLine("NUMBER= " + a);
       Console.WriteLine("SALARY= " + pay.ToString("F2", CultureInfo.InvariantCulture));

       */

        //************************************************

        // 5 * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código

        Console.WriteLine("Entre com o código, número de peças e valor unitário da peça 1 (mesma linha)");
        string[] vet1 = Console.ReadLine().Split(' ');
        int codPeca1 = int.Parse(vet1[0]);
        int numPeca1 = int.Parse(vet1[1]);
        double valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com o código, número de peças e valor unitário da peça 2 (mesma linha)");
        string[] vet2 = Console.ReadLine().Split(' ');
        int codPeca2 = int.Parse(vet2[0]);
        int numPeca2 = int.Parse(vet2[1]);
        double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

        double valTotal = valorPeca1 + valorPeca2;

        Console.WriteLine("VALOR A PAGAR: " + valTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}


