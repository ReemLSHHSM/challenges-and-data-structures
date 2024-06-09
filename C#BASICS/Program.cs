namespace C_BASICS
{
    internal class Program
    {

        static void Main(string[] args)
        {
          /*  int[] arr1 = { 2, 55, 7, 4 };
           

            //Challange a
            int[] arr2 = ArrayReversal(arr1);
            Console.WriteLine("Original: " + String.Join(",", arr1));
            Console.WriteLine("Reverse: " + String.Join(",", arr2));

            //Challangeb
            int[] arr3 = { 1, 1,1,1,1, 2, 2, 3, 3, 3, 2, 3, 5, 5, 6, 7, 8, 3, 2, 1,2,3 };
          

            Console.WriteLine(FrequentNumber(arr3))*/


            //Challange 2
            int []arr4 = { };
            Console.WriteLine(MaximumValue(arr4));
        }









        //Challange a
        public static int[] ArrayReversal(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[arr.Length - i - 1];
            }


            return arr2;
            ;

        }

        //...............................................................................
        //challange b
        public static int FrequentNumber(int[] arr)
        {
            int frek = arr[0];
            int count2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > count2)
                {
                    count2 = count;
                    frek = arr[i];
                    if (count2 == 1)
                    {
                        frek = arr[0];
                    }
                }
            }

            return frek;
        }

        //Challange 2
         public static int MaximumValue(int[] arr)
        {
            if (arr.Length > 0)
            {
                int max = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }

                return max;
            }
            else
            {
                return 0;
            }

           
        }

    }
}
