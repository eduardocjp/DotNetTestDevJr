using System.Collections.Generic;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) 
        {  
        int totalNumbers = numbers.Count;
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }

        decimal positiveRatio = (decimal)positiveCount / totalNumbers;
        decimal negativeRatio = (decimal)negativeCount / totalNumbers;
        decimal zeroRatio = (decimal)zeroCount / totalNumbers;

    
        positiveRatio = Math.Round(positiveRatio, 6);
        negativeRatio = Math.Round(negativeRatio, 6);
        zeroRatio = Math.Round(zeroRatio, 6);

        
        return new List<decimal> { positiveRatio, negativeRatio, zeroRatio };
        }
    }
}
