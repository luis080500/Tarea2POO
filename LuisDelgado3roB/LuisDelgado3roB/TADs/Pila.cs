using System;
using System.Collections.Generic;
using System.Text;

namespace LuisDelgado3roB.TADs
{
    public class Pila
    {

        private int[] data = new int[5];

        public int[] Data
        {
            get { return data; }
            set { data = value; }
        }
        private int cima = -1;

        public int Cima
        {
            get { return cima; }
            set { cima = value; }
        }
        public void EliminarData ()
        {
            if (Cima == -1)
                throw new Exception("No hay datos en la Pila");
            else
                Cima--;
        }
        public void Anadir(int numero) {
            if (Cima<(Data.Length-1))
            {
                Cima++;
                Data[Cima] = numero;
            }
        
        
        
        }



    }
}
