using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Program
{
    // Creating a class named Sequence
    public class Sequence
    {
        // For Storing the sequences in a list
        int n;
        List<int> list = new List<int>();
        List<int> max = new List<int>();

        //Taking the input using constructor
        public Sequence(int n)
        {
            this.n = n;
        }

        public void genrateSequence()
        {
            Console.Write("The Sequence: ");
            // Generating the Sequence as given
            while (n != 0)
            {
                Console.Write(n + " ");
                //Storing the sequence
                list.Add(n);

                //Formula for odd number : number = (number * 3) + 1(except 1)
                if (n % 2 == 1 && n != 1)
                {
                    n = (n * 3) + 1;
                }
                //Formula for even number : number = number / 2;
                else n /= 2;

            }
            Console.WriteLine();

        }

        //find and save the largest values for the largest sum
        public void saveLargestSum()
        {
            Console.Write("Largest Sum From the 5 Numbers: ");

            for (int c = 0; c < 5; c++)
            {
                int pos = -1;

                int mx = -1;

                // Storing the position of max value in the list
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > mx)
                    {

                        mx = list[i];

                        pos = c;

                    }
                }
                if (pos < 0) break;
                Console.Write(list[pos] + " ");

                max.Add(list[pos]);

                //setting the max value to the lowest
                list[pos] = -1;

            }
            Console.WriteLine();
        }


        // Doing the sum and storing the max 5 elements
        public void getMax5()
        {

            //storing the elements in descending order and print them
            max.Sort((a, b) => b.CompareTo(a));

            Console.Write("Sorted in Descending Order: ");

            foreach (int element in max)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {

        Console.Write("Enter Integer Number for the Sequence: ");

        // Taking input from the user
        int n = Int32.Parse(Console.ReadLine());

        Sequence s = new Sequence(n);

        s.genrateSequence();

        s.saveLargestSum();

        s.getMax5();
    }
}