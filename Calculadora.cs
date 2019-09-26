using System;
using System.Collections.Generic;

namespace trabalho01
{
    public class Calculadora
    {
        private List<float> _memoria = new List<float>();
        public List<float> Memoria { get => _memoria; set => _memoria = value; }


        public float RealizarOperacao(float Numero1, float Numero2, string operacao)
        {
            float resultado = float.NaN;
            switch (operacao)
            {
                case "a":
                    resultado = Adicionar(Numero1, Numero2);
                    break;

                case "s":
                    resultado = Subtrair(Numero1, Numero2);
                    break;

                case "m":
                    resultado = Multiplicar(Numero1, Numero2);
                    break;

                case "d":
                    resultado = Dividir(Numero1, Numero2);
                    break;

                default:
                    break;
            }
            return resultado;
        }

        public float RealizaMedia(string opcao)
        {
            float result = 0;
            switch (opcao)
            {

                case "t":
                   result = Total();
                    break;
                case "md":
                   result = Media();
                    break;

                default:
                    break;
            }
            
            return result;
        }


        private float Adicionar(float Numero1, float Numero2)
        {
            return Numero1 + Numero2;
        }

        private float Subtrair(float Numero1, float Numero2)
        {
            return Numero1 - Numero2;
        }

        private float Multiplicar(float Numero1, float Numero2)
        {
            return Numero1 * Numero2;
        }

        private float Dividir(float Numero1, float Numero2)
        {
            return Numero1 / Numero2;
        }


         float Media()
         {
             float soma = 0;
             float media = 0;
             for (int i = 0; i < Memoria.Count; i++)
             {
                 soma = soma + Memoria[i];
             }
             media = soma / Memoria.Count;
             return media;
         }

         private float Total()
         {
             float soma = 0;
             for (int i=0; i< Memoria.Count; i++)
             {
                 soma = soma + Memoria[i];
             }
             return soma;
         }

    }
}