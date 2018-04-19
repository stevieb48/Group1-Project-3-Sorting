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
 * file name: BubbleSorter.cs
 * version: 1.0
 */
namespace Sorters
{
    //
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

        //private method sorts array parameter and sets the sorted array property privately
        private void Sort(int[] unsortedArray)
        {
            // temporary array
            int[] tempArray = unsortedArray;

            // create temporary element
            int tempElement = tempArray[0];

            //Start loop equal to number of comparisons to make, then decrement
            for (int j = tempArray.Length - 1; j > 0 ; j--)
            {
                Boolean swapMade = false; //boolean to keep track of if a swap has been made in the last pass

                for (int i = 0; i < j; i++)
                {
                    //
                    if (tempArray[i] > tempArray[i + 1])
                    {
                        tempElement = tempArray[i + 1];
                        tempArray[i + 1] = tempArray[i];
                        tempArray[i] = tempElement;
                        swapMade = true;
                    }
                }
                if(swapMade == false) //if no swaps were made, break out of the loop
                {
                    break;
                }

            }

            // set private property with tempArray thats now sorted
            this.SortedArray = tempArray;
        }

        // private method to store array elements into a string variable
        public string GetContentOfArrayElements()
        {
            string arrayElementContents = "";

            foreach (int element in this.SortedArray)
            {
                arrayElementContents = arrayElementContents + (element.ToString()) + ", ";
            }

            return arrayElementContents;
        }

        // ToString method to display the contents of the Bubble Sorter object which calls the private method
        // to Get Content Of Array Elements
        public override string ToString()
        {
            return ("the EnhancedBubbleSorter the array = " + GetContentOfArrayElements());
        }
    }
}