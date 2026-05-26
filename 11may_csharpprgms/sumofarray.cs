//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class sumofarray
//{

//    public static void Main()
//    {
//        Console.WriteLine("enter the size of array");
//        int size = int.Parse(Console.ReadLine());

//        int[] ar = new int[size];
//        int sum = 0;
//        Console.WriteLine("Enter the elements");
//        for (int i = 0; i < ar.Length; i++)
//        {
//            ar[i] = int.Parse(Console.ReadLine());
//            sum=sum+ar[i];//
//        }
//        Console.WriteLine("**Task 1**");

//        Console.WriteLine("Sum of array is:"+sum);



//        Console.WriteLine("**Task 2**");
//        //enter index 5 and print the element
//        Console.WriteLine("enter the index");
//        int index = int.Parse(Console.ReadLine());
//        int count = 0;
//        for (int i = 0; i < ar.Length; i++)
//        {
//            if (i == index)
//            {
//                count++;
//                break;
//            }

//        }
//        if (count == 0)
//        {
//            Console.WriteLine("element not found!!!");
//        }
//        else
//        {
//            Console.WriteLine("element is:" + ar[index]);
//        }
//    }
//}
