//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class employee
//{
//    public virtual void bonus()
//    {
//        Console.WriteLine(" every employee should get the bonus");
//    }

//}
//class manager : employee
//{
//    public override void bonus()
//    {
        
//        Console.WriteLine("manager bonus:80000");
//    }
//}
//    class developer:employee
//    {
//        public override void bonus()
//        {
        
//        Console.WriteLine("developer bonus:100000");
//        }
//    }
//class tester:employee
//    {
//        public override void bonus()
//        {
//        base.bonus();
//        Console.WriteLine("tester bonus:50000");
//        }
//}
//class methodoverride
//{
    
//    public static void Main(string[] args)
//    {
//        tester t=new tester();
//        t.bonus();
        
//        developer d=new developer();
//        d.bonus();
//         manager m=new manager();
//        m.bonus();
//    }
//}
