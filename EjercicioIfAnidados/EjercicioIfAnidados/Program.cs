namespace EjercicioIfAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar primera nota");
            float num1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Ingresar segunda nota");
            float num2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresar  tercer nota");
            float num3 = float.Parse(Console.ReadLine());

            float prom = (num1 + num2 + num3) / 3;

            if (prom >= 9.5 && prom <= 10)
            {
                Console.WriteLine("Excelente: ");
            }
            else if(prom >= 8.5 && prom <= 9.4)
            {
                Console.WriteLine("Muy bien");

            }else if(prom >= 7.5 && prom <= 8.4)
            {
                Console.WriteLine("Bien");

            }else
            {
                Console.WriteLine("Bruta asquerosa, no sabes nada de la vida JAJAJAJAJAAJAJAJAJAJA");
            }


        }
    }
}
