using System;

namespace MaxElement
{

    class HandleArray
    {

        public static int FindGreatestArrayElement(int [] array)
        {
            //sum of all element 
            int sumofALLElements = 0,number=0;
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sumofALLElements += array[i];
                }
                if (sumofALLElements > 0)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        int sumofotherElements = sumofALLElements - array[j];

                        if ((array[j] - sumofotherElements) > 0 && number < array[j])
                        {

                            number = array[j];
                        }

                    }
                }
            }
            catch (IndexOutOfRangeException io)
            {
                throw new IndexOutOfRangeException("Error occured in processing " + io.Message);
            }

            return number;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputarray = new int[] { 10, 20, 30, 40, 90, 2000, 20 };
            int result = 0;
            try
            {
                 result = HandleArray.FindGreatestArrayElement(inputarray);
                Console.WriteLine("Processing successful!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Processing failed!! " + ex.Message);
            }
            if (result > 0)
            {
                Console.WriteLine("Max number= {0}", result);
            }
            else
            {
                Console.WriteLine("None");
            }


        }
    }
}
