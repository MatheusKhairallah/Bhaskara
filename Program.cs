using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores númericos");
            Console.Write("Valor um: ");
            double A=Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor dois: ");
            double B=Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor três: ");
            double C=Convert.ToDouble(Console.ReadLine());

            double resultadoΔ=Math.Pow(B, 2);
            double resultadoΔ2=resultadoΔ -4 * A * C;

            double resultadoBas=-(B);
            double resultadoBas2=Math.Sqrt(resultadoΔ2);
            double resultadoBas3=2 * A;

            double resultadoX1=(resultadoBas + resultadoBas2) / resultadoBas3;
            double resultadoX2=(resultadoBas - resultadoBas2) / resultadoBas3;
            
            Console.Clear();
            
            if(A==0)
            Console.WriteLine($"A equação não é do segundo grau.");
            else if(resultadoΔ2<0)
            Console.WriteLine($"Como delta = {resultadoΔ2}, a equação não possui raízes reais!");
            else
            Console.WriteLine($"A={A}, B={B}, C={C}, então X1= {resultadoX1} e X2= {resultadoX2}");
            
             


            





        }
    }
}
