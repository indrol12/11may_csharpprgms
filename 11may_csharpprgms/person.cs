//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

// class person
//    {
//    int pid; //instance variable
//    string city;
//    long phno;

//    person(int pid,string city,long phno)//constructor with parameters
//    {
//        this.pid=pid;//this keyword is used to refer the current class instance variable
//        this.city=city;//this keyword is used to refer the current class instance variable
//        this.phno=phno;//this keyword is used to refer the current class instance variable
//    }
//    person(person pp)//copy constructor
//    {
//        this.pid = pp.pid;
//        this.city = pp.city;
//        this.phno = pp.phno;
//    }
//    public static void Main(string[] args)
//    {
//        person p1 = new person(32,"banglore",89076543);
//        Console.WriteLine("person id is "+p1.pid);
//        Console.WriteLine("person city is "+p1.city);
//        Console.WriteLine("person phone number is "+p1.phno);

//        Console.WriteLine("----------------Copy Constructor------------------");
//        person p2=new person(p1);//calling copy constructor
//        Console.WriteLine("person id is "+p2.pid);//copy constructor is used to copy the values of one object to another object
//        Console.WriteLine("person city is "+p2.city);
//        Console.WriteLine("person phone number is "+p2.phno);
//    }

//}

