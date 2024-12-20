using System;

namespace FigurasGeometricas
{
    // Clase para representar un Círculo
    public class Circulo
    {
        // Propiedad para almacenar el radio del círculo
        public double Radio { get; set; }

        // Constructor que inicializa el radio
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // Método para calcular el área de un círculo
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo
        // Requiere como argumento el radio del círculo
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        // Método para calcular el perímetro de un círculo
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

    // Clase para representar un Cuadrado
    public class Cuadrado
    {
        // Propiedad para almacenar el lado del cuadrado
        public double Lado { get; set; }

        // Constructor que inicializa el lado
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Método para calcular el área de un cuadrado
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un cuadrado
        // Requiere como argumento el valor del lado del cuadrado
        public double CalcularArea()
        {
            return Lado * Lado;
        }

        // Método para calcular el perímetro de un cuadrado
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }

    // Clase para representar un Rectángulo
    public class Rectangulo
    {
        // Propiedades para almacenar las dimensiones del rectángulo
        public double Largo { get; set; }
        public double Ancho { get; set; }

        // Constructor que inicializa el largo y el ancho
        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        // Método para calcular el área de un rectángulo
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un rectángulo
        // Requiere como argumento el largo y el ancho del rectángulo
        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        // Método para calcular el perímetro de un rectángulo
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio de 5 unidades
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

            // Crear un cuadrado con lado de 4 unidades
            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine("\nCuadrado:");
            Console.WriteLine("Área: " + cuadrado.CalcularArea());
            Console.WriteLine("Perímetro: " + cuadrado.CalcularPerimetro());

            // Crear un rectángulo con largo 6 y ancho 3
            Rectangulo rectangulo = new Rectangulo(6, 3);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine("Área: " + rectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
        }
    }
}


