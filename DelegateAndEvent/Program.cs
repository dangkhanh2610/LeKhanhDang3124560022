using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

delegate void UpdateNameHandler(string name);
class Program
{
    static int showString(string stringValue)
    {
        System.Console.WriteLine(stringValue);
        return 0;
    }

    static void nhapVaShowTen(MyDelegate showTen)
    {
        System.Console.WriteLine("Mời nhập tên của bạn: ");
        string ten = Console.ReadLine();
        showTen(ten);
    }
    delegate int MyDelegate(string s);
    static void Main(string[] args)
    {   
        Console.OutputEncoding = Encoding.Unicode;

        MyDelegate showStr = new MyDelegate(showString);
        nhapVaShowTen(showStr);
        System.Console.WriteLine();

        HocSinh hs = new HocSinh();
        hs.NameChanged += Hs_NameChanged;
        hs.Name = "Lê Khánh Đăng";
        System.Console.WriteLine("Tên từ class: " + hs.Name);
        hs.Name = "Độ Mixi";
        System.Console.WriteLine("Tên từ class: " + hs.Name);
        Console.ReadLine();
    }

    private static void Hs_NameChanged(string name)
    {
        System.Console.WriteLine("Tên mới: " + name);
    } 
        
}

class HocSinh
{
    public event UpdateNameHandler NameChanged;

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            if(NameChanged != null)
            {
                NameChanged(Name);
            }
        }
    }
}

