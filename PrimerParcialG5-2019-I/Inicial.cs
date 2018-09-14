using System;

namespace PrimerParcialG5_2019_I
{
    abstract class Inicial
    {
        private byte n;
        public float [] arreglo;

        public byte N {
            get => n;
            set
            {
                if( value <= 5 )
                {
                    n = 5;
                }
                else if( value > 20)
                {
                    n = 20;
                }

                else
                {
                    n = value;
                }                
            }
        }

        public virtual float [] Leer(string cadena)
        {
                       
            string[] valores = cadena.Split(',');
            N =(byte)valores.Length;

            arreglo = new float[N];
            for ( int i=0; i< N; i++   )
            {
                arreglo[i] = float.Parse( valores[i]);
            }
            return arreglo;
        }       


    }
}
