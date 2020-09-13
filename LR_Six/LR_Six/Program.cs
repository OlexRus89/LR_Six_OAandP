using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LR_Six
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 27

#if DEBUG
            Console.Write("Введите данные для стороны куба. A: ");
#endif

#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"cube_output.txt");
            var new_in = new StreamReader(@"cube_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Cube c = new Cube();
            c.Load();
            c.Info();

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif
        }
    }
}
