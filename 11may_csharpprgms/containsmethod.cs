//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//class containsmethod
//    {
//    static void checkstring()
//    {
//        Console.WriteLine("Enter the string");
//        string str = Console.ReadLine();//asha

//        Console.WriteLine("Enter the character");
//        char ch = char.Parse(Console.ReadLine());//s
//        int flag = 0;
//        for (int index = 0; index < str.Length; index++)
//        {//index=0  0<4true  index=1  1<4true
//            if (ch == str[index])//s==st[0] s==0false  s==st[1] s==s true
//            {
//                flag = 1;
//                break;
//            }
//        }
//        if (flag == 1)
//        {
//            Console.WriteLine("character is found!!");
//        }
//        else
//        {
//            Console.WriteLine("character is not found!!");
//        }
//    }
//    public static void Main(string[] args)
//    {
//        checkstring();
//    }
//}
