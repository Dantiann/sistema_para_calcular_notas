using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOLETIN DE CALIFICACIONES");
            
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            var studentTotal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************");
            Console.WriteLine("");

            for (int i = 0; i < studentTotal; i++) 
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                var studentName = Console.ReadLine();

                Console.WriteLine("Ingrese la asignatura: ");
                var asignature = Console.ReadLine();

                var suma = 0.0F;
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("Ingrese la nota " + j + ": ");
                    var nota = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    while (nota <=0 || nota > 5) 
                    {
                        Console.WriteLine("Valor errado. El valor a registar debe ser entre 1 y 5. Ingrse la nota " + j + ": ");
                        nota = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                    suma += nota;
                }
                var promedio = suma / 5;

                string estado;
                if (promedio >= 3) 
                {
                    estado = "APROBADO";
                }
                else
                {
                    estado = "NO APROBADO";
                }
                Console.WriteLine("__________________");
                Console.WriteLine(" ");
                Console.WriteLine($"Alumno: {studentName}; Nota final: {promedio}; Estado: {estado}");
                Console.WriteLine("");
                Console.WriteLine("******************");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
