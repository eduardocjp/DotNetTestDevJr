using System.Collections.Generic;

namespace Tasks
{
    public class Task3
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list)
         {
       if (list == null || list.Count == 0)
           return 0;

       int sum = 0;
       foreach (int num in list)
       {
           if (num > 0)
               sum += num;
       }
       
       return sum;
   }
    }
}
