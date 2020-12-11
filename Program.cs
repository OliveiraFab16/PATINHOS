using System;
using Figgle;

namespace PATINHOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pato;

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Programa Educacional Para Crianças");
            Console.WriteLine("");
            Console.ResetColor();

            DateTime horaSistema = DateTime.Now;
             Console.WriteLine($"{horaSistema}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(FiggleFonts.Big.Render("Patinhos"));
            Console.ResetColor();
            
            Console.Write("Digite o número de patinhos? ");
            Pato = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = Pato; i > 0; i -= 1)
            {
            Console.ForegroundColor = ConsoleColor.Blue;    
            Console.WriteLine(i + " Patinhos foram passear");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;  
            Console.WriteLine("Além das montanhas");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;  
            Console.WriteLine("Para brincar");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            Console.WriteLine("Mas só " + (i - 1) + " patinhos voltaram de lá.");
            Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("A mamãe patinha foi procurar");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            Console.WriteLine("Além das montanhas");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Na beira do mar");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
            Console.WriteLine("E os " + Pato + " patinhos voltaram de lá.");
             Console.ResetColor();
        }
    }
}
