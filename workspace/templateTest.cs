using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> _list=new List<T>();
    public void Add(T x)
    {
        _list.Add(x);
    }
    public T this[int index]
    {
        get{
            return _list[index];
        }
    }
    public int Count
    {
        get{
            return _list.Count;
        }
    }
}
struct Person{
    public string name{ get;set;}
    public int id{set;get;} 
    public override string ToString()
    {
        return "name:"+name+" id:"+id;
    }
}
class Student{
    public string name{ get;set;}
    public int id{set;get;} 
    public override string ToString()
    {
        return "name:"+name+" id:"+id;
    }
}
interface IDepos
{
    void test();
}
//泛型及泛型参数约束
//泛型参数限定为不可谓null的值类型
; class LimitStructTemplate<T> where T:struct
{
    public LimitStructTemplate(T value)
    {
        this.m_value=value;
    } 
    private T m_value;
    public string MyToString()
    {
        return m_value.ToString();
    }
}
//泛型参数限定为引用类型
class LimitClassTemplate<T> where T:class
{

}
// //泛型参数限定为可为null的引用类型
// class LimitNullableClassTemplate<T> where T:class?
// {

// }
//泛型参数限定为不可为null的类型
// class LimitNoNullableTemplate<T> where T:notnull
// {

// }
//泛型参数限定为不可为null的非托管类型
// class LimitNoNullableUnManagedTemplate<T> where T:unmanaged
// {

// }
//泛型参数限定为某一类或其派生类
class LimitBaseClassTemplate<T> where T:Student
{

}
//泛型参数限定为某一类或其派生类,该类型可为null
class LimitNullableBaseClassTemplate<T> where T:Student
{

}
//泛型参数限定为指定接口或实现指定接口的类
class LimitInterfaceTemplate<T> where T:IDepos
{

}
// //泛型参数限定为指定接口或实现指定接口的类,可为null
// class LimitNullableInterfaceTemplate<T> where T:IDepos?
// {

// }
//类型参数必须具有公共无参数构造函数。 与其他约束一起使用时，new() 约束必须最后指定。 new() 约束不能与 struct 和 unmanaged 约束结合使用。
class LimitNoArgumentConstructor<T> where T:new()
{

}
public class MyTest{
    public static void Main(string []args)
    {
        List<int> list_t=new List<int>();
        MyList<int> list=new MyList<int>();
        list.Add(5);
        list.Add(6);
        list.Add(7);
        list.Add(8);
        for(int i=0;i<list.Count;++i)
        {
            Console.WriteLine(list[i]);
        }
        //
        Person p=new Person();
        Student s=new Student();
        p.name="Chen Yi";
        p.id=2016;
        LimitStructTemplate<Person> person=new LimitStructTemplate<Person>(p);
        Console.WriteLine(person.MyToString());
        LimitStructTemplate<int> intV=new LimitStructTemplate<int>(10);
        Console.WriteLine(intV.MyToString());
        Console.WriteLine(default(Object)==null);
        // 下面代码是错误的
        // ReferPerson<Student> student=new ReferPerson<Student>();
        // Console.WriteLine(student.MyToString());

    }
}