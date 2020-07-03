//委托，函数对象
using System;

delegate int Function(int x);
public class Multiplier
{
    public int Multiply5(int x) {return x*5;}
}
public class FunctionObjectTest
{
    static int Add5(int x){return x+5;}
    static int[] Apply(int[] a,Function f)
    {
        int[] res=new int[a.Length];
        for(int i=0;i<a.Length;++i)
        {
            res[i]=f(a[i]);
        }
        return res;
    }
    static public void Main(string []args)
    {
        int[] nums={0,1,2,5,8,6};
        foreach(var num in Apply(nums,Add5))
        {
            Console.WriteLine(num);
        }
        Multiplier multiplier=new Multiplier();
        foreach(var num in Apply(nums,multiplier.Multiply5))
        {
            Console.WriteLine(num);
        }
        foreach (var num in Apply(nums,(int x)=>{return x*x;}))
        {
            Console.WriteLine(num);
        }
    }
}
