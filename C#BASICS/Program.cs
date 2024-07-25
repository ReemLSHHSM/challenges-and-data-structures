

using System.Xml.Linq;

namespace C_BASICS
{
    public class Program
    {

        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList(new Node(7));
            //list.addtoHead(new Node(6));
            //list.addtoHead(new Node(5));
            //list.addtoHead(new Node(4));

            

            //Console.WriteLine("Original list:");
            //list.PrintList();
            //Console.WriteLine(list.Includes(5));
            //list.Remove(5);
            //Console.WriteLine("List after removing duplicates:");
           
            //list.RemoveDuplicate();



            //LinkedList list2 = new LinkedList(new Node(3));
            //list2.addtoHead(new Node(2));
           
            //list2.addtoHead(new Node(0));
            //list2.addtoHead(new Node(0));
            //list2.addtoHead(new Node(1));
            //Console.WriteLine("Merged List:");
            //list.MergeSorted(list, list2);
            
            //Stack
            Stack stack= new Stack();

            Console.WriteLine(stack.isEmpty());

            stack.push(1);
            stack.push(2);
            stack.push(3);
            Console.WriteLine(stack.isEmpty());

            Console.WriteLine($"{stack.Pop()} was poped");

            Console.WriteLine($"Top of the stack is {stack.Peek()}");

            //Queue
              Queue queue= new Queue();
            Console.WriteLine("Before enqueueing");
            Console.WriteLine(queue.IsEmpty());

            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("After enqueueing");
            Console.WriteLine(queue.IsEmpty());

            Console.Write("this data was poped: ");
            Console.WriteLine(queue.Dequeue());

            Console.Write("First in queue is: ");
            Console.WriteLine(queue.Peek());
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
        //Challange 3
        public static int[] RemoveMiddleValue(int[] arr)
        {
            if (arr.Length == 0)
            {
                return arr;
            }

            int newLength;
            if (arr.Length % 2 == 0)
            {
                newLength = arr.Length - 2;
            }
            else
            {
                newLength = arr.Length - 1;
            }

            int[] arr_tempo = new int[newLength];
            int middle = arr.Length / 2;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length % 2 != 0 && i == middle)
                {
                    continue;
                }
                else if (arr.Length % 2 == 0 && (i == middle || i == middle - 1))
                {
                    continue;
                }
                else
                {
                    arr_tempo[index++] = arr[i];
                }
            }
            arr = arr_tempo;

            return arr;
        }

        //Challange 4
        public static int[] MiddleValue(int[] arr, int value)
        {

            var arr_new = new int[arr.Length + 1];


            for (int i = 0; i < arr_new.Length; i++)
            {

                if (arr.Length % 2 == 0)
                {
                    if (i != (arr.Length / 2) && i < (arr.Length / 2))
                    {
                        arr_new[i] = arr[i];
                    }
                    else
                    {
                        // if(i == (arr.Length / 2))
                        //  {
                        arr_new[arr.Length / 2] = value;
                        if (i != (arr.Length / 2))
                            arr_new[i] = arr[i - 1];
                        // }
                    }
                }

                else
                {
                    if (i != (arr_new.Length / 2) && i < (arr_new.Length / 2))
                    {
                        arr_new[i] = arr[i];
                    }

                    else
                    {


                        arr_new[arr_new.Length / 2] = value;
                        if (i != (arr_new.Length / 2))
                            arr_new[i] = arr[i - 1];
                    }
                }


            }



            arr = arr_new;

            return arr;
        }

        //Challange 5
        public static int[] FindDuplicates(int[] arr)
        {

            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        result.Add(arr[i]);
                    }

                }


            }
            return result.ToArray();
        }

        public static int [] CommonElements(int[] arr1, int[] arr2)
        {
            
            HashSet<int> common = new HashSet<int>();
            List<string> string_elemnts = new List<string>();
            if (arr1.Length == arr2.Length)
            {


                for (int i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {

                        if (arr1[i] == arr2[j])
                        {

                            common.Add(arr1[i]);
                            break;
                        }
                    }

                }



            }
            else
            {
                if(arr1.Length> arr2.Length)
                {
                    for(int i = 0;i < arr2.Length; i++)
                    {
                        string_elemnts.Add(arr2[i].ToString());
                    }

                    for (int j = arr1.Length-arr2.Length;j < arr1.Length; j++)
                    {
                        string_elemnts.Add("*");

                    }

                    for(int i = 0; i < arr1.Length; i++)
                    {
                        for(int j=0; j < arr1.Length; j++)
                        {
                            if(arr1[i].ToString() == string_elemnts[j])
                            {
                                common.Add(arr1 [i]);
                            }
                        }
                    }
                }

                else
                {
                    for(int i = 0;i < arr1.Length; i++)
                    {
                        string_elemnts.Add(arr1[i].ToString());
                    }

                    for (int j = arr2.Length-arr1.Length;j < arr2.Length; j++)
                    {
                        string_elemnts.Add("*");

                    }

                    for(int i = 0; i < arr2.Length; i++)
                    {
                        for(int j=0; j < arr2.Length; j++)
                        {
                            if(arr2[i].ToString() == string_elemnts[j])
                            {
                                common.Add(arr2 [i]);
                            }
                        }
                    }
                }
            }

            return common.ToArray();
        }
    }
}
