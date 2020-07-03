//ArrayList 可变长数组，其中的元素为Object类型
//List<T> 可变长数组，使用了泛型，比ArrayList更高效
//HashTable 哈希表，key和value都是Object类型的，存取值类型靠的是频繁的拆箱装箱
//Dictionary<T,U> 字典，HashTable的泛型版本
//HashSet<T> 哈希集合，泛型，可以做高性能集合运算
//Queue 和 Queue<T>,Stack 和 Stack<T>
//SortedList和SortedList<T,U>，内部维护的是有序数组
//SortedDictionary<TKey,TValue>,红黑树,不能使用下标
//ListDictionary（单向链表）,LinkedList<T>(双向链表)
//BitArray用于二进制运算
//HybridDictionary,内置了HashTable和ListDictionary两个容器
using System;
using System.Collections;

public class CollectionsTest{
    public static void Main(string[] args)
    {
        //HashTable
        Hashtable table=new Hashtable();
        table.Add("120",1200);
        Console.WriteLine(table["120"]);
        //SortedList
        SortedList sortedList=new SortedList();
        sortedList.Add(10,"AAA");
        sortedList.Add(8,1235);
        sortedList.Add(12,7);
        foreach(var key in sortedList.Keys)
        {
            Console.WriteLine(key.ToString()+" "+sortedList[key].ToString());
        }
        byte[] a={60};
        byte[] b={13};
        //BitArray
        BitArray bitArray1=new BitArray(a);
        BitArray bitArray2=new BitArray(b);
        for(int i=0;i<bitArray1.Count;++i)
        {
            if(bitArray1[i]) Console.Write(1);
            else Console.Write(0);
        }
        Console.WriteLine();
        for(int i=0;i<bitArray2.Count;++i)
        {
            if(bitArray2[i]) Console.Write(1);
            else Console.Write(0);
        }
        Console.WriteLine();
        BitArray bitArray3=bitArray1.Or(bitArray2);
        for(int i=0;i<bitArray2.Count;++i)
        {
            if(bitArray3[i]) Console.Write(1);
            else Console.Write(0);
        }
        Console.WriteLine();
    }
}