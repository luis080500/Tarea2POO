using System;
using LuisDelgado3roB.TADs;
namespace LuisDelgado3roB
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila r = new Pila();

            r.Anadir(5);
            r.Anadir(10);
            r.Anadir(3);
            r.Anadir(8);
            r.EliminarData();
            r.Anadir(4);

            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(r.Data[i]);

            }
            Cola c = new Cola();
            c.Anadirdato(6);
            c.Anadirdato(9);
            c.Anadirdato(4);
            c.Anadirdato(12);
            c.EliminarDato();
            c.Anadirdato(65);
            Console.WriteLine("\ncola");
            for (int i = c.Ultimo; i >c.Primero; i--)
            {
                Console.WriteLine(c.Dato[i]);

            }
            Console.ReadKey();




        }
    }
}
