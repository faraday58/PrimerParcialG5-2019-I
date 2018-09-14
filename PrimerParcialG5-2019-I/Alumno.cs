using System;

namespace PrimerParcialG5_2019_I
{
    class Alumno:Inicial
    {

        public override float[] Leer(string cadena)
        {
            return base.Leer(cadena);
        }

        public float Promedio()
        {
            float suma = 0;
            float promedio = 0;

            for(int i=0; i < N; i ++)
            {
                suma += arreglo[i]; // suma= suma +arreglo[i];
            }

            promedio = suma / N;
            return promedio;
        }

        public override string ToString()
        {

            string promedio = "Promedio de Estudiante: " + Promedio(); 

            return promedio;
        }

    }
}
