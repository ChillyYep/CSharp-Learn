using System;

class Binder
{
    public void Bind(){
        Console.WriteLine("绑定成功！");
    }
}
interface IControl
{
    void Paint();
}
interface IDataBound
{
    void Bind(Binder b);
}
class EditBox:IControl,IDataBound
{
    public void OnlyMyFunc()
    {
        Console.WriteLine("OnlyMyFunc");
    }
    //C#接口的特殊之处，方法前加上接口前缀，使其只能被显式的接口类型访问
    void IControl.Paint(){
        Console.WriteLine("O - O");
    }
    void IDataBound.Bind(Binder b){
        b.Bind();
    }
}
public class InterfaceTest
{
    public static void Main(string[] args)
    {
        EditBox editBox=new EditBox();
        editBox.OnlyMyFunc();
        IControl control=editBox;
        control.Paint();
        IDataBound dataBound=editBox;
        Binder binder=new Binder();
        dataBound.Bind(binder);
    }
}