using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuantasVecesCabe
{
    internal class Operacion
    {
        private int num1 { get; set; } = 0;
        private int num2 { get; set; } = 0;
        private int resultado { get; set; } = 0;

        public void Datos()
        {
            try
            {
                Console.WriteLine("Por favor ingrese el primer número mayor a 1000 y el segundo menor a 100");

                do
                {                            
                    Console.Write("\nNumero 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    if (num1 < 1000)
                    {
                        Console.WriteLine("\nNúmero incorrecto vuelva a intentar");
                    }

                } while (num1 < 1000);

                do
                {
                    Console.Write("\nNumero 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 > 100)
                    {
                        Console.WriteLine("\nNúmero incorrecto vuelva a intentar");
                    }

                } while (num2 > 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }                
        }

        public int Calculo() 
        {
            return resultado = num1 / num2;
        }
    }
}
