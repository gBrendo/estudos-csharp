using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
/// <summary>
/// Aqui veremos sobre classes, atributos e metodos estaticos, e a diferença entre eles e os normais.
/// </summary>

namespace InicioEstudo
{
    class Sessao4
    {
        static void main(string[] args)
        {

            // Resolvendo um problema sem OOP
            /* 
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo x: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: x");
            }
            else
            {
                Console.WriteLine("Maior area: y'");
            }
            */

            // Agora vaoms criar CLASSES para representar melhor o problema, e para isso vamos criar uma classe chamada Triangulo, com os atributos A, B e C, e um metodo para calcular a area do triangulo, e outro para comparar as areas dos triangulos.
            
            /*A CLASSE é um tipo estruturado que pode contar(menbros): Atributos(dados/campos) Métoros(funcoes/operaçoes)
              A CLASSE também pode prover muitos outros recursos, tais como: Construtores, Sobrecarga, Emcapsulamento,Herança, Polimorfismo.
              Exemplos: Entidades: produto, cliente, triangulo
                        Serviços: ProdutoService, ClienteServoce,EmailService, StorgeService
                        Controladores: ProdutoController, ClienteController
                        Utilitarios: Calculadora, Compactador
                        Outros(Views, repositorios, gerenciadores, etc) */





        }
    }
}
