using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorters
{
    public class EnhancedBubbleSorter
    {
 
  // This is super sloppy but isn't this what our professor is looking for in the 'enhanced' bubble sort?
  // If someone could double check me that'd be great, making a nb
        {
            // temporary array
            int[] tempArray = unsortedArray;

            // create temporary element
            int tempElement = tempArray[0];

            //
            for (int i = 1; i <= tempArray.Length - 1; i++)
            {
                //
                for (int j = 0; j <= tempArray.Length - 1-i; j++)
                {
                    //
                    if (tempArray[j] > tempArray[j + 1])
                    {
                        tempElement = tempArray[j + 1];
                        tempArray[j + 1] = tempArray[j];
                        tempArray[j] = tempElement;
                    }
                }
            }

        }
        
    }
}
