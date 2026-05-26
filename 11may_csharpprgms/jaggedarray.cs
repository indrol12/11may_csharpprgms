//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//    class jaggedarray
//    {
//    public static void Main(string[] args)
//    {
//        //jagged array declaration
//        int[][] nums = new int[3][];

//        //jagged array intializing elements
//        nums[0] = new int[] { 4,6};
//        nums[1] = new int[] { 7, 12, 9, 3, 1 };
//        nums[2] = new int[] { 8, 2, 0 };

//        //iterating elements
//        for (int i = 0; i < nums.Length; i++)
//        {//i=0 0<3true
//         //i=1 1<3true
//         //i=2  2<3true
//         //i=3 3<3false
//            //row iteratiom
//            for (int j = 0; j < nums[i].Length; j++)
//            {//j=0   num[0].length =2 0<2true 
//              //j=1    1<2true
//              //j=2   2<2false

//                //j=0  num[1].length 5 
//                Console.Write(nums[i][j]+" ,");
//                //nums[0][0]=4
//                //num[0][1]==6

//            }
//            Console.WriteLine();
//        }

//    }
//}
