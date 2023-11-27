using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n) 
        {
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++) 
            {
                listaSalida.Add(5*(i+1));
            }

            return listaSalida;
        }
    
    public List<int> GenerarValoresPseudoaleatoriosCongruenciales(int x0, int a, int c, int m, int totalValores)
    {
        //Paso 1: Inicializamos valore genero
        int valorGenerado = x0;
        List<int> listaSalida = new List<int>();
        for (int i= 0; i < totalValores; i++)
        {
            // Paso 2: Calculamos el siguiente valor
            int valorGeneradoAux = (a * valorGenerado + c) % m;
            // Paso 3 Guardamos el valor nuevo
            listaSalida.Add(valorGeneradoAux);
            // Paso 4 Seteamos el siguiente valor
            valorGenerado = valorGeneradoAux;
        }
        return listaSalida;
    }
}
}



