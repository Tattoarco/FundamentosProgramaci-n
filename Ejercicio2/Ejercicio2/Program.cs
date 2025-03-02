namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿El personaje de juego pudedisparar?");
            Console.WriteLine("Ingresa true para hacer invencible al personaje o false para lo contrario");
            string invensible = Console.ReadLine();

            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 

            if (invensible == "true" && numero > 0)
            {
                Console.WriteLine("Tienes: "+numero+" municiones");
                Console.WriteLine("El personaje está disparando");
            }
        }
    }
}
