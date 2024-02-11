using System;

namespace MeuApp{
    class Program{
        static void Main(string[] args){
            var text = "testing";
            Console.WriteLine(text);

            //nullable
            int? idade = 0;
            Console.WriteLine(idade);
            idade = null;
            Console.WriteLine(idade);
            idade = 25;
            Console.WriteLine(idade);

            //parses
            int inteiro = 100;
            float real = 25.5f;
            real = inteiro; // 100.0f
            inteiro = (int)real;
            inteiro = int.Parse(real.ToString());
            inteiro = Convert.ToInt32(real);
        }
    }
}