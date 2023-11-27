﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    
    public List<int> GenerarValoresPseudoaleatoriosNoCongruencial(int n)
    {
        // Creacion de algoritmo para generar valores pseudoaleatorios con el Metodo del producto medio
        Random rnd = new Random();

        // Paso 1: Declarar variables iniciales de la primera fila
        int r0 = rnd.Next(1000);
        int r1 = rnd.Next(1000);
        int rn_2 = 0;


        List<int> listaSalida = new List<int>();

        listaSalida.Add(r0);

        for (int i = 0; i < n-1; i++)

        {
            // Paso 2: Calculamos r(n)*r(n+1)
            rn_2 = r0 * r1;

            // Paso 3: Calculamos m_rn_2
            string m_rn_2 = rn_2.ToString();
            m_rn_2 = m_rn_2.Substring(1, m_rn_2.Length - 1);
            int m_rn_2_int = Int32.Parse(m_rn_2);

            // Paso 4: Calculamos valor1
            int m_rn_2_size = m_rn_2.Length;
                string valor1_string;
            if(m_rn_2_size > 3){
                    valor1_string = m_rn_2.Substring(0, 3);
            } else{
                valor1_string = m_rn_2;
            }

            int valor1 = Int32.Parse(valor1_string);

            // Paso 5: Calculamos valor2
            int valor2 = 0;
            if (m_rn_2_size <= 3)
            {
                valor2 = 0;
            } else {
                string valor2_string = m_rn_2.Substring(m_rn_2_size - 3);
                valor2 = Int32.Parse(valor2_string);
            }

            r0 = r1;
            r1 = valor1;

            // Paso 3 Guardamos el valor nuevo
            listaSalida.Add(r0);
        }

        return listaSalida;
    }
}
}



