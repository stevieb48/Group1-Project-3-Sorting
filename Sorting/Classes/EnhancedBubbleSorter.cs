using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class EnhancedBubbleSorter is used by ProgramSort. This class constructor takes in an integer array 
 * as a parameter, sorts it, and stores the sorted array.
 *
 * author: Group 1 (Louis Anthony, Tristan Barrett, Timothy Bates, Stephen Bailey)
 * course: COP4365C
 * assignment: Project 3
 * date: 03/25/2018
 * file name: EnhancedBubbleSorter.cs
 * version: 1.0
 */
namespace Sorters
{
    public class EnhancedBubbleSorter
    {
        // auto implemented property
        public int[] SortedArray { get; private set; }

        // constructor takes in an array parameter
        public EnhancedBubbleSorter(int[] unsortedArray)
        {
            // call private method to Sort array parameter
            Sort(unsortedArray);
        }

        //private method sorts array parameter and sets the sorted array property
        private void Sort(int[] unsortedArray)
        {
            // temporary array
            int[] tempArray = unsortedArray;

            // create temporary element
            int tempElement = tempArray[0];

            //
            for (int i = 1; i <= tempArray.Length - 1; i++)
            {
                //
                for (int j = 0; j <= tempArray.Length - 1 - i; j++)
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

            // set private property with tempArray thats now sorted
            this.SortedArray = tempArray;
        }

        // private method to store array elements into a string variable
        public string GetContentOfArrayElements(int[] array)
        {
            string arrayElementContents = "";

            foreach (int element in array)
            {
                arrayElementContents = arrayElementContents + (element.ToString()) + ", ";
            }

            return arrayElementContents;
        }

        // ToString method to display the contents of the enhanced Bubble Sorter object which calls 
        // the private method to Get Content Of Array Elements
        public override string ToString()
        {
            return ("\n the Enhanced BubbleSorter sorted array = " + GetContentOfArrayElements(this.SortedArray));
        }
    }
}