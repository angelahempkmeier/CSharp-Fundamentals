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
        }
    }
}