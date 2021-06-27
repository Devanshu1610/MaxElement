using System;

namespace MaxElement
{

    class HandleArray
    {

        public static int FindGreatestArrayElement(int [] array)
        {
            //sum of all element 
            int sumofALLElements = 0,number=0;
            for (int i = 0; i < array.Length; i++)
            {
                sumofALLElements += array[i];
            }
            if (sumofALLElements > 0)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int sumofotherElements = sumofALLElements - array[j];

                    if ((array[j] - sumofotherElements) > 0&& number < array[j])
                    {
                      
                            number = array[j];
                    }
                   
                }
            }

            return number;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputarray = new int[] { 10, 20, 30, 40, 90, 200, 20 };
            int result =HandleArray.FindGreatestArrayElement(inputarray);
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
