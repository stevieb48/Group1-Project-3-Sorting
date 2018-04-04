using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorters;
/*
 * This class ProgramSort sorts a prefilled array using the BubbleSort class and the EnhancedBubbleSort class.
 *
 * author: Group 1 (Louis Anthony, Tristan Barrett, Timothy Bates, Stephen Bailey)
 * course: COP4365C
 * assignment: Project 3
 * date: 03/25/2018
 * file name: ProgramSort.cs
 * version: 1.0
 */
namespace Sorting
{
    public class ProgramSort
    {
        static void Main(string[] args)
        {
            // create array to sort
            int[] arrayToSort = new int[] { 5, 10, 23, 81, 2, 99, 37, 74, 48, 56 };
            int[] arrayToSort2 = new int[] { 5, 10, 15, 20, 25, 99 };

            // string to hold array elements for display to console
            string arrayToSort_ElementContents = "";

            // loop through array to sort and store into string for display to console
            foreach (int element in arrayToSort)
            {
                arrayToSort_ElementContents = arrayToSort_ElementContents + (element.ToString()) + ", ";
            }

            // write to console elements of the array to sort
            Console.WriteLine("\nContents of the array prior to using the BubbleSorter."
                                + "\n unsorted array = " + arrayToSort_ElementContents);

            // create new bubble sorter and input the array to sort as a parameter
            BubbleSorter newBubbleSorter = new BubbleSorter(arrayToSort);

            // toString to show the contents of the bubble sorter object with array sorted
            Console.WriteLine("\nContents of the array after using the BubbleSorter."
                                + newBubbleSorter.ToString());

            // create new enhanced bubble sorter and input the array to sort as a parameter
            EnhancedBubbleSorter newEnhancedBubbleSorter = new EnhancedBubbleSorter(arrayToSort);

            // toString to show the contents of the enhanced bubble sorter object with array sorted
            Console.WriteLine("\nContents of the array after using the EnhancedBubbleSorter."
                                + newEnhancedBubbleSorter.ToString());

            // pause the console
            Console.ReadKey();
        }
    }
}