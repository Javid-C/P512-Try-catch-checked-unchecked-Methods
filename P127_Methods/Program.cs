using System;

namespace P127_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //int num = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[50];
            //int index = 0;
            //if (num <= 50)
            //{
            //    for (int i = 3; i <= num; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            arr[index] = i;
            //            index++;
            //        }
            //    }
            //}
            //else if (num > 50 && num <= 100)
            //{
            //    for (int i = 5; i <= num; i++)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            arr[index] = i;
            //            index++;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 8; i <= num; i++)
            //    {
            //        if (i % 8 == 0)
            //        {
            //            arr[index] = i;
            //            index++;
            //        }
            //    }
            //}

            //foreach (int number in arr)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion


            #region Task 2 
            //string[] words = { "Avaz", "Oruc", "Isa", "Gunel", "Lutfiyar", "Allahshukur", "Parvin" };

            //foreach (string word in words)
            //{
            //    if (word.Length > 5)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion


            #region Task 3
            //int num = 10;
            //int total = 0;
            //while(num > 0)
            //{
            //    int remainder = num % 10;
            //    total += remainder;
            //    num /= 10;
            //}
            //Console.WriteLine(total);

            #endregion


            #region Try, catch, finally
            //int[] arr;
            //try
            //{
            //    arr = new int[50];

            //    for (int i = 0; i < 100; i++)
            //    {
            //        arr[i] = i;
            //    }
            //    int zero = 0;
            //    int five = 5;

            //    Console.WriteLine(five/zero);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Qeyd elediyiviz array uzunlugu duzgun deyil");
            //    arr = new int[100];
            //    for (int i = 0; i < 100; i++)
            //    {
            //        arr[i] = i;
            //    }
            //    try
            //    {
            //        int zero = 0;
            //        int five = 5;

            //        Console.WriteLine(five / zero);
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //        try
            //        {

            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //    }
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Eded sifira bolune bilmez");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("After exception");
            //}


            //checked
            //{
            //    int max;
            //    int sum;
            //    try
            //    {
            //        max = int.MaxValue;
            //        sum = 2 + max;
            //        Console.WriteLine(sum);
            //    }
            //    catch (Exception e)
            //    {
            //        long max3 = int.MaxValue;
            //        long sum3 = 22999444333 + max3;
            //        Console.WriteLine(sum3);
            //    }
            //}
            #endregion



            int[] arr = { 1, 3, 5, 9, 10, 12, 20, 21, 22 };

            Divide(arr, 3);
            Divide(arr, 4);
            Divide(arr, 5);
            Divide(arr, 6);
            //foreach (int num in arr)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}


            //Console.WriteLine("Divided by 3");
            //foreach (int num in arr)
            //{
            //    if (num % 3 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}


            //Console.WriteLine("Divided by 5");
            //foreach (int num in arr)
            //{
            //    if (num % 5 == 0)
            //    {
            //        Console.WriteLine(num);

            //    }
            //}
            //Console.WriteLine(Sum(55,10));

            int total = Sum(55, 10);

            //Console.WriteLine(total);

            //AnyProcess("Parvin","Rustamli");
            //Console.WriteLine(fullname);
            //AnyProcess("Oruc","Dostuyev");

            //Console.WriteLine(Sum(60));

            //Console.WriteLine(Fullname(surname:"Aliyev",name:"Ali"));

        }

        public static int Sum(int num1, int num2=0)
        {
            for (int i = 0; i < 5; i++)
            {
                num1 += num2;
            }
            return num1;
        }

        public static void AnyProcess(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }

        public static string Fullname(string name, string surname)
        {
            return name + " " + surname;
        }

        public static void Divide(int[] arr,int number)
        {
            Console.WriteLine("Divided by " + number);
            foreach (int num in arr)
            {
                if (num % number == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
