namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Ingresa las cordenadas para el punto P1(x1,y1)---");
            Console.WriteLine("Ingresa x");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa y");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("---Ingresa las cordenadas para el punto P2(x2,y2)---");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa y");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("---Ingresa las cordenadas para el punto P3(x3,y3)---");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa y");
            double y3 = double.Parse(Console.ReadLine());

            //Distancia entre dos puntos p1 y p2
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Distancia entre dos puntos p2 y p3
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            //Distancia entre dos puntos p1 y p3
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            Console.WriteLine($"Distancia entre P1 y P2: {a}");
            Console.WriteLine($"Distancia entre P2 y P3: {b}");
            Console.WriteLine($"Distancia entre P1 y P3: {c}");

            if((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Las distancias pueden formar un triángulo.");
            }
            else
            {
                Console.WriteLine("Las distancias NO pueden formar un triángulo.");
            }   


        }
    }
}
