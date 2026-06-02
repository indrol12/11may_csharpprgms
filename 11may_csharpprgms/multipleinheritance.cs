using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface suresh
{
    public void money();
}
interface ramesh
{
    public void property();
}
class golu: suresh, ramesh
{
    public void money()
    {
        Console.WriteLine("suresh has 1000 rs");
    }
    public void property()
    {
        Console.WriteLine("ramesh has 2 house");
    }
}
   class multipleinheritance
    {
    }

