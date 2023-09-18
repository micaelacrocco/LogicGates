using System;
using System.Collections.Generic;



namespace Library
{
    // Subclase para la compuerta OR
    public class CompuertaOR : Compuerta
    {
        private List<Compuerta> entradas = new List<Compuerta>();

        public void AgregarEntrada(Compuerta entrada)
        {
            entradas.Add(entrada);
        }

        public override bool Calcular()
        {
            // Realizar la operación lógica OR en las entradas
            bool resultado = false;
            foreach (var entrada in entradas)
            {
                resultado = resultado || entrada.Calcular();
            }
            return resultado;
        }
    }
    
}