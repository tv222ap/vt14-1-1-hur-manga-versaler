using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaknaVersaler.Model
{
    public class TextAnalyzer
    {
        public string StringToCount { get; set; }
        public int GetNumberOfCapitals()
        {
            int numCap = 0;

            for (int i = 0; i < StringToCount.Length; i++)
            {
                if (char.IsUpper(StringToCount[i]))
                {
                    numCap++;
                }
            }
            return numCap; 
        }

        
        
    }
}