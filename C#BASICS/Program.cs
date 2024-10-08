﻿
using System.Xml.Linq;
using C_BASICS.MinStack;
using C_BASICS.Trees;
using linkedlist = C_BASICS.LinkedList.LinkedList;//this is an alies

namespace C_BASICS
{
    public class Program
    {

        static void Main(string[] args)
        {

            //BinarySearchTree tree = new BinarySearchTree(10);

            //tree.Add(3);

            //tree.Add(1);
            //tree.Add(5);
            //tree.Add(2);
            //tree.Add(7);

            //Console.WriteLine(tree.Contains(0));
            //tree.Mirror();

            Node node= new Node(1);

            linkedlist list= new linkedlist(node);

            list.Add_Node(2);
            list.Add_Node(3);
            list.Add_Node(4);
            list.Add_Node(5);
            list.Add_Node(6);
            list.Add_Node(7);
            list.PrintList();
            Console.WriteLine("============");
            Console.WriteLine();
            list.RotateLeft(8);
            list.PrintList();
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
