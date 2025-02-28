namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo número");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 != num2 && num1 != num3)
            {
                if (num2 != num1 && num2 != num3)
                {
                    if(num3 != num1 && num3 != num2)
                    {
                        if (num1 > num2 && num1 > num3)
                        {
                            Console.WriteLine("El número más grande es: " + num1);
                        }else if (num2 > num1 && num2 > num3)
                        {
                            Console.WriteLine("El número más grande es: " + num2);
                        }else if(num3 > num1 && num3 > num2)
                        {
                            Console.WriteLine("El número más grande es: " + num3);
                        }

                        int[] numeros = { num1, num2, num3 };

                        Array.Sort(numeros);

                        Console.WriteLine("Números en orden ascendente:");
                        foreach (int num in numeros)
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }else
            {
                Console.WriteLine("Ingresar números diferentes");
            }
        }
    }
}
