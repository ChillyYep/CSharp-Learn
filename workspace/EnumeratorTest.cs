using System;
using System.Collections;
using System.Collections.Generic;
//迭代器测试
//IEnumerable<T> 可迭代的对象
//IEnumerator<T> 迭代器

//自定义可迭代对象
public class CustomEnumerableObject:IEnumerable
{
    string[] words=new string[4];
    public CustomEnumerableObject()
    {
        words[0]="I";
        words[1]="am";
        words[2]="Chen";
        words[3]="Yi";
    }
    //需要实现IEnumerable中的GetEnumerator方法，在foreach中调用该方法获取迭代器
    public IEnumerator GetEnumerator()
    {
        return this.words.GetEnumerator();
    }
}
public class EnumeratorTest{
    public IEnumerable<int> GetSingleDigitOddNumbers(bool getCollection)
    {
        if(false==getCollection)
        {
            return new int[0];
        }
        else return IteratorMethod();
    }
    private IEnumerable<int> IteratorMethod()
    {
        int index=0;
        while(index<10)
        {
            if(1==index%2)
                yield return index;
            ++index;
        }
    }
    public static void Main(String []args)
    {
        int []arr=new int[5]{1,2,3,4,5};
        //foreach enumerable<T>对象，编译后与以下代码类似
        try{
            var enumerator=arr.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }
        }
        finally{
            //----------------------------------------
        }
        foreach(var element in arr)
        {
            Console.WriteLine(element.ToString());
        }
        EnumeratorTest enumeratorTest=new EnumeratorTest();
        foreach(var element in enumeratorTest.GetSingleDigitOddNumbers(true))
        {
            Console.WriteLine(element.ToString());
        }
        CustomEnumerableObject enumerableObject=new CustomEnumerableObject();
        foreach(var element in enumerableObject)
        {
            Console.Write(element+" ");
        }
    }
}