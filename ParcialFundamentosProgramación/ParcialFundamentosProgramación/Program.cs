namespace ParcialFundamentosProgramación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario = 2500000;

            Console.WriteLine("----¡Hola, bienvenio al software de empleados!----");
            Console.WriteLine("----¡Valores aceptados para la calificación!----");
            Console.WriteLine("---------- 0.0, 0.4, 0.6 o 1.0 ----------");

            Console.WriteLine("Ingesar el nombre del empleado");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar la calificación del año presente");
            float calificacionActual = float.Parse(Console.ReadLine());

            if (calificacionActual == 0.0f || calificacionActual == 0.4f || calificacionActual == 0.6f || calificacionActual == 1.0f)
            {
           
                Console.WriteLine("Ingresar el número de años trabajados");
                int añosTrabajados = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar la calificación del año anterior");
                float calificacionAnterior = float.Parse(Console.ReadLine());

                if (calificacionAnterior == 0.0f || calificacionAnterior == 0.4f || calificacionAnterior == 0.6f || calificacionAnterior == 1.0f)
                {
                    float promedio = (calificacionAnterior + calificacionActual) / 2;

                    if (añosTrabajados < 1)
                    {
                        salario = salario + (salario * 0.00f);
                    }
                    else if (añosTrabajados > 5)
                    {
                        salario = salario + (salario * 0.30f);
                    }
                    else if (5 >= añosTrabajados && añosTrabajados > 0 && 0 <= promedio && promedio < 0.4)
                    {
                        salario = salario + (salario * 0.05f);
                    }
                    else if (5 >= añosTrabajados && añosTrabajados > 0 && 0.4 <= promedio && promedio < 0.6)
                    {
                        salario = salario + (salario * 0.10f);
                    }
                    else if (5 >= añosTrabajados && añosTrabajados > 0 && 0.6 <= promedio && promedio < 1)
                    {
                        salario = salario + (salario * 0.20f);
                    }

                    Console.WriteLine("El salario de " + nombre + " es de: " + salario + " y su promedio es: " + promedio);
                }
                else
                {
                    Console.WriteLine("¡Error!, Valores no válidos");
                }
            }
            else
            {
                Console.WriteLine("¡Error!, Valores no válidos");
            }
        }

    }

}   





