using System.Collections.Generic;

namespace Tasks
{
    public class Task1
    {      
    
        public static int GetMax(List<int> list) 
        {
        if (list == null || list.Count == 0)
            return null;
            
        int max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] > max)
                max = list[i];
        }
       
        return max;
        }

    }

    
        
    
    
