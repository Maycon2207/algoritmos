using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        public static object Retangulo { get; private set; }

        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();


            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Lado = 10;
            obj3.Lado2 = 5;
            obj3.IMprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 4;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Base = 10;
            obj5.Altura = 5;
            Console.WriteLine($"Triângulo com base de {obj5.Base} e altura de {obj5.Altura} possui uma área de " + obj5.CalcularArea());

        }
      
    }
    public class Quadrado
    {
        public int Lado;
        public int CalcularArea()
        {
            int area = Lado * Lado;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de " + CalcularArea());
        }
    }   
        public class Retangulo
        { public int Lado;
            public int Lado2;
            public int CalcularArea()
            {
                int area = Lado * Lado2;
                return area;
            }
            public void IMprimeArea()
            {
                Console.WriteLine($"Retangulo com lados de {Lado} e {Lado2} possui uma área de " + CalcularArea());
            }
        }
    public class Circulo
    {
        public double Raio;
        public double CalcularArea()
        {
            double area = Math.PI * Raio * Raio;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma área de " + CalcularArea());
        }
    }
    public class Triangulo
    {
        public double Base;
        public double Altura;
        public double CalcularArea()
        {
            double area = (Base * Altura) / 2.0;
            return area;
        }   
    } 
}
