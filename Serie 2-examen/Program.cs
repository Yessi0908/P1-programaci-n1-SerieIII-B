using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_2_examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, ingrese un correo con dominio de Gmail por favor");
            string cgmail = Console.ReadLine();

           if (cgmail.EndsWith("gmail.com"))
            {
                string cndom = cgmail.Replace("gmail.com", "miumg.edu.gt");
                Console.WriteLine("Su nuevo dominio es: " +  cndom);

            }
            else
            {
                Console.WriteLine("Verificar si el dominio es de Gmail"); 
            }
           
        }

    }
}
