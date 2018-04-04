using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class BubbleSorter is used by ProgramSort. This class constructor takes in an integer array 
 * as a parameter, sorts it, and stores the sorted array.
 *
 * author: Group 1 (Louis Anthony, Tristan Barrett, Timothy Bates, Stephen Bailey)
 * course: COP4365C
 * assignment: Project 3
 * date: 03/25/2018
 * file name: BubbleSorter.cs
 * version: 1.0
 */
namespace Sorters
{
    public class BubbleSorter
    {
        // auto implemented property
        public int[] SortedArray { get; private set; }

        // constructor takes in an array parameter
        public BubbleSorter(int[] unsortedArray)
        {
            // call private method to Sort array parameter
            Sort(unsortedArray);
        }

        //private method sorts array parameter and sets the sorted array property
        private void Sort(int[] unsortedArray)
        {
            //
            const int SEARCH_OFFSET = 2;

            // temporary array
            int[] tempArray = unsortedArray;

            // create temporary element
            int tempElement = tempArray[0];

            // counter j is less than number of array elements minus offset
            for (int j = 0; j <= tempArray.Length - SEARCH_OFFSET; j++)
            {
                // counter i is less than number of array elements minus offset
                for (int i = 0; i <= tempArray.Length - SEARCH_OFFSET; i++)
                {
                    // if value in element is greater than the value in the next element of the array
                    if (tempArray[i] > tempArray[i + 1])
                    {
                        // set temp element to the element in the array that is less
                        tempElement = tempArray[i + 1];

                        // put the element with the greater value into the element where the lesser value was
                        tempArray[i + 1] = tempArray[i];

                        // put the element with the lesser int the element where the greater value was
                        tempArray[i] = tempElement;
                    }
                }
            }

            // set private property with tempArray thats now sorted
            this.SortedArray = tempArray;
        }

        // private method to store array elements into a string variable
        public string GetContentOfArrayElements(int[] array)
        {
            // create empty string
            string arrayElementContents = "";

            // for each element in this sorted array
            foreach (int element in array)
            {
                // build a string containing all the values separated by a comma
                arrayElementContents = arrayElementContents + (element.ToString()) + ", ";
            }

            // return the string
            return arrayElementContents;
        }

        // ToString method to display the contents of the Bubble Sorter object which calls the private method
        // to Get Content Of Array Elements
        public override string ToString()
        {
            return ("\n the BubbleSorter sorted array = " + GetContentOfArrayElements(this.SortedArray));
        }
    }
}