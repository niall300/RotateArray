using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //rotATE LEFT 10
            //41 73 89 7 10 1 59 58 84  (r)77 77 97 58 1 86 58 26 10 86 51
            //expected output
            //77 97 58 1 86 58 26 10 86 51 41 73 89 7 10 1 59 58 84 77




            int[] x = { 13,9,27,86,42,12};
            //int rotation = 4;
            //int[] x = { 41, 73, 89, 7, 10, 1,
             //   59, 58, 84, 77, 77, 97, 58, 1 ,86, 58, 26, 10, 86, 51 };
            
            //PrintArray(RotateRight(x,1));
            //PrintArray(RotateRight(x, 2));
            //PrintArray(RotateRight(x, 3));
            //PrintArray(RotateRight(x, 4));
            PrintArray(x);
            Console.WriteLine("Rotate Right by 5, Expected Output: ");
            Console.WriteLine("9 27 86 42 12 13");
            //PrintArray(RotateLeft(x, 1));
            //PrintArray(RotateLeft(x, 2));
            PrintArray(RotateRight(x, 5));
            //PrintArray(RotateLeft(x, 4));
            Console.ReadLine();

        }

        //29/05/2017 working fine
        public static int[] RotateLeft(int[] inputArray, int rotate)
        {
            //if the rotation is a minus figure return the original array
            //take care of divide by zero
            if (rotate <= 0)
            {
                return inputArray;
            }
            //logic to take care of large rotation i.e. larger than the array

            rotate = rotate % inputArray.Length;

            
            

            //create new rotated array same length as original
            int[] leftRotatedArray = new int[inputArray.Length];
            //counter to populate rotated array
            int counter = 0;
            //if array contains 0 or 1 element return original array
            if (inputArray.Length == 0 || inputArray.Length == 1)
            {
                return inputArray;
            }
            //populate rotatedarray in 2 parts
            //first part
            //start at the end of input array
            //and move backwards to rotate

            for (int i = inputArray.Length-1; i >= rotate ; i--)
            {
                //start rotatedArray at length - rotate
                leftRotatedArray[i - rotate] = inputArray[i];

              

            }

            
           
            //second part
            //start at zero and go to rotate
            
            for (int i = 0; i < rotate; i++)
            {
                //fix
                int startPoint = leftRotatedArray.Length - rotate;
               leftRotatedArray[startPoint + i] = inputArray[i];

              
            }

           

            return leftRotatedArray;
        }

        //29/05/2017 working fine
        public static int[] RotateRight(int[] inputArray, int rotate)
        {
            //if the rotation is a minus figure return the original array
            //take care of divide by zero
            if (rotate <= 0)
            {
                return inputArray;
            }

            //logic to take care of large rotation i.e. larger than the array
            
            rotate = rotate % inputArray.Length;
                     
            //counter to poulate rotated array
            int counter = 0;

            //create new rotated array same length as original
            int[] rightRotatedArray= new int[inputArray.Length];

            //if array contains 0 or 1 element return original array
            if(inputArray.Length == 0 || inputArray.Length == 1)
            {
                return inputArray;
            }

            //populate rotatedarray with the last elements 
            //starting at the index = to the number of rotations
            
            for(int i = inputArray.Length-rotate; i < inputArray.Length;  i++)
            {
                //start rotatedArray at zero
                rightRotatedArray[counter] = inputArray[i];

                //increment counter for rotatedArray
                counter++;
               
              
               
            }
            //foreach (var v in rotatedArray)
            //{
            //    Console.WriteLine(v);
            //}
            //Console.ReadLine();
            //***TODO*****
            //populate rotated array from input array starting at index 0 to index length-rotate

            int counter2 = 0;
            for (int i = rotate; i < inputArray.Length; i++)
            {
                 
                rightRotatedArray[i] = inputArray[counter2];
                counter2++;
            }
            //foreach (var v in rotatedArray)
            //{
            //    Console.WriteLine(v);
            //}
            //Console.ReadLine();
            return rightRotatedArray;

        }
        //Rotate array to the right of a given pivot
        public static int[] Pivotrotate(int[] inputArray, int pivot)
        {


            int[] pivoted = new int[inputArray.Length];
            


            int indexCounter = 0;
            //this loop populates the array with everything from the pivot to the end
            for (int i = pivot; i < inputArray.Length; i++)
            {
                pivoted[indexCounter] = inputArray[i];
                indexCounter++;
            }

            //this loop populates the array from zero index to the pivoy
            for (int j = 0; j < pivot; j++)
            {
                pivoted[indexCounter] = inputArray[j];
                indexCounter++;
            }
            return pivoted;
        }

        public static void PrintArray(int[] myArray)
        {
            foreach(int x in myArray)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}

            




