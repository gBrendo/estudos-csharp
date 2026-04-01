// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;



namespace InicioEstudo
{


    /*
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

            /*

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

            */
            //**************************************************************************

            //Exercício 06 * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            /*mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/

            /*  double A, B, C, triangulo, circulo,trapezio,quadrado, retangulo;

              string[] vet = Console.ReadLine().Split(' ');
              A = double.Parse(vet[0], CultureInfo.InvariantCulture);
              B = double.Parse(vet[1], CultureInfo.InvariantCulture);
              C = double.Parse(vet[2], CultureInfo.InvariantCulture);

              triangulo = A * C / 2.0;
              circulo = 3.14159 * C * C;
              trapezio = (A + B) * C / 2.0;
              quadrado = B * B;
              retangulo = A * B;

              Console.WriteLine("TRIANGULO; "+ triangulo.ToString("F3", CultureInfo.InvariantCulture));
              Console.WriteLine("CIRCULO: "+ circulo.ToString("F3", CultureInfo.InvariantCulture));
              Console.WriteLine("TRAPEZIO: "+ trapezio.ToString("F3", CultureInfo.InvariantCulture));
              Console.WriteLine("QUADRADO: "+ quadrado.ToString("F3", CultureInfo.InvariantCulture));
              Console.WriteLine("RETANGULO: "+ retangulo.ToString("F3", CultureInfo.InvariantCulture));

              Console.WriteLine("Conclusao By Brendo");*/

            /********************************************************************************************/


            // OPERADORES COMPARATIVOS

            /*

            int a = 10;
            bool c1= a < 10;
            bool c2= a < 20;
            bool c3= a > 10;
            bool c4 = a > 5;
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("----------------------------");
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);

            */

            /********************************************************************************************************************/

            //ESTRUTURA CONDICIONAL(IF-ELSE)

            // estrutura simples
            /*int x = 10;

            Console.WriteLine("Bom dia");

            if (x > 5)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");
            */

            // estrutura composta
            /* Console.WriteLine("Entre com um numero inteiro");
             int x = int.Parse(Console.ReadLine());

             if (x % 2 == 0)
             {
                 Console.WriteLine("Par");
             }
             else
             {
                 Console.WriteLine("Impar");
             }

             */

            // estrutura encadeada(encadeamento de if-else, else if)

            /*

            Console.WriteLine("Qual horario atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");


            }
            */

            // ESCOPO DE INICIALIZAÇÃO DE VARIÁVEIS

            /* quando se declara uma variavel dentro do if, ou entre parenteses ela so existe ali dentro. Nao pode ser usada em outros lugares, ou escopos. Nao se pode 
            tentar usar uma variavel de um escopo menor em um escopo maior, pois não ira enchergar.*/


            // EXERCICIO PROPOSTOS DE FIXAÇÃO - ESTRUTURA CONDICIONAL

            //01 * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            /*
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("POSITIVO");
            }
            if (num < 0) { Console.WriteLine("NEGATIVO"); }

            Console.WriteLine("FIM DO PROGRAMA");

            */

            //02 * Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            /*


            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) { Console.WriteLine("PAR"); }
            else { Console.WriteLine("IMPAR"); }

            Console.WriteLine("FIM DO PROGRAMA");

            */

            //03 * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            //ordem crescente ou decrescente.

            /*

            int a, b;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("SAO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NAO SAO MULTIPLOS");
            }

            Console.WriteLine("FIM DESSA COISA CHATA");
            */

            //04 * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            /*
            int hrinicial,hrfinal,duracao;

            string[] vet = Console.ReadLine().Split(' ');
            hrinicial = int.Parse(vet[0]);
            hrfinal = int.Parse(vet[1]);
            duracao = 0;

            if(hrfinal > hrinicial)
            {
                duracao = hrfinal - hrinicial;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");  
            }
            else { 
            duracao = 24 - hrinicial + hrfinal;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            */

            //05 ** Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            //seguir, calcule e mostre o valor da conta a pagar
            /*

            string[] vet = Console.ReadLine().Split(' ');
            int item = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double total = 0.0;

            if (item == 1)
            {
                total = quantidade * 4.00;

            }
            else if (item == 2)
            {
                total = quantidade * 4.50;
            }
            else if (item == 3)
            {
                total = quantidade * 5.00;
            }
            else if (item == 4)
            {
                total = quantidade * 2.00;
            }
            else if (item == 5)
            {
                total = quantidade * 1.50;
            }
            else {Console.WriteLine("ITEM INEXISTENTE"); }

            Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            //06

            /*

            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0 && num <= 25)
            {
                Console.WriteLine("Intervalo: [0,25]");
            }
            else if (num > 25 && num <= 50)
            {
                Console.WriteLine("Intervalo: (25,50]");
            }
            else if (num > 50 && num <= 75)
            {
                Console.WriteLine("Intervalo: (50,75]");
            }
            else if (num > 75 && num <= 100)
            {
                Console.WriteLine("Intervalo: (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            */


            // AULA SOBRE FUNÇOES // DEBUG

            /*

            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

            /* static int Maior(int a, int b, int c)
        {
            int m;
            if(a > b && a > c)
            {
                m = a;
            }
            else if(b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
       */

            // ESTRURURA DE REPETIÇÃO - WHILE "ENQUANTO" - nesse caso o programa sempre irá testar a logica pelo que esta dentro dos parenteses do while.

            /*
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo!");
            */

            /*****************************************************************/

            // EXERCICIO DE FIXAÇÃO - ESTRUTURA DE REPETIÇÃO - WHILE

            /* -01 - Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
             incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
             mpressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

            int senha = int.Parse(Console.ReadLine());

            while( senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            */

            // - 02 /* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            /*cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).


           string[] vet = Console.ReadLine().Split(' ');
           int x = int.Parse(vet[0]);
           int y = int.Parse(vet[1]);


           while (x != 0 && y != 0)
           {
               if (x > 0 && y > 0)
               {
                   Console.WriteLine("Primeiro");

               }
               else if (x < 0 && y > 0)
               {
                   Console.WriteLine("Segundo");
               }
               else if (x < 0 && y < 0)
               {
                   Console.WriteLine("Terceiro");

               }
               else
               {
                   Console.WriteLine("Quarto");

               }

              vet = Console.ReadLine().Split(' ');
               x = int.Parse(vet[0]);
               y = int.Parse(vet[1]);
           }
            */

            /****************************************************************/

            //03 

            /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int cod = int.Parse(Console.ReadLine());
            
            while(cod != 4 )
            {
                if (cod == 1)
                {
                    alcool = alcool + 1;
                }
                else if (cod == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if(cod == 3)
                {
                    diesel = diesel + 1;
                }

                cod = int.Parse(Console.ReadLine()) ;
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+ alcool);
            Console.WriteLine("Gasolina: "+ gasolina);
            Console.WriteLine("Diesel: "+ diesel);

        
            */

            // ESTRUTURA REPETITIVA - FOR (PARA) // for(inicio;condicao;incremento){ comandos...}
            /* É mais utilizada quando vc ja conhece a quantidade de repetições ou contagem. */

            /*
            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ",i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("Soma = " + soma);
            */

            // EXERCICIOS DE FIXAÇÃO - ESTRUTURA DE REPETIÇÃO - FOR


            //01 - fazer um programa que vc coloca um valor X  e mostre os impares ate chegar no X.
            /*
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //02
            /*
            int N = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < N; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 || valor > 20)
                {
                    
                   fora++;

                }
                else
                {
                    
                    dentro++;
                }

                Console.WriteLine(dentro + " in");
                Console.WriteLine(fora + " out");
            }
            */

            //03
            /*

            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string [] vet = Console.ReadLine().Split(' '); 
                double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture); 
                double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture); 
                double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (v1 * 2 + v2 * 3 + v3 * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            */
            // exercicio resolvido
            /*
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <=10; i++)
            {
                int resultado = i * N;

                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
            */

            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine()); 
            y = int.Parse(Console.ReadLine());

            if(x<y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);


        }


        

    }
}


  