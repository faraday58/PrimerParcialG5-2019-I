using System;

namespace PrimerParcialG5_2019_I
{
    class Imprime:Inicial
    {
        public override float[] Leer(string cadena)
        {
            return base.Leer(cadena);
        }

        public string  Ingresado()
        {
            string aux="";

            for(int i=0; i < N; i++)
            {
                aux =aux +" " +   arreglo[i];
            }
            
            return aux;
        }

        public string  Inverso()
        {
            string aux = "";
            for(int i=N-1; i >= 0; i--)
            {
                aux = aux + " " + arreglo[i];
            }
            return aux;

        }

        public string Par()
        {
            string aux="";
            for(int i=0; i < N; i+=2 )
            {
                aux = aux + " " + arreglo[i];
            }
            return aux;
        }


    }
}
