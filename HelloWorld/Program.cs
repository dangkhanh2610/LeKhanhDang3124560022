using System;
using System.Data;
using HelloWorld.Service;
namespace HelloWorld;



class Program
{

    public class PaymentAccount
    {
        protected decimal Balance{get; set;}
        public string Owner {get;}
        public PaymentAccount(string owner, decimal opening)
        {   
            Owner = owner;
            Balance = opening;   
        }
        
        public virtual decimal CalculateFee(decimal amount) 
            => amount * 0.001m;
    }

    public class SavingsAccount : PaymentAccount
    {
        public decimal InterestRate {get;}
        public SavingsAccount(string owner, decimal opening, decimal rate) : base (owner, opening)
        {
            InterestRate = rate;
        }
        public override decimal CalculateFee(Decimal amout)
            => 36m;
    }
    static void Main(String[] args)
    {
        // int day = 36;
        // string res = day switch
        // {
        //     2 => "Monday",
        //     3 => "Tuesday",
        //     _ => "Unknown"
        // };
        // Console.WriteLine(res);

        // string text = "abc";
        // bool result = int.TryParse(text, out int number);

        // Console.WriteLine(result);
        // Console.WriteLine(number);

        // int[] soNguyen = new int[5];
        // int[] soThuc = {1, 6, 3, 8, 9, 4, 5, 7};
       
        // System.Console.WriteLine($"Truoc: [{string.Join(", ", soThuc)}]");
        // Array.Sort(soThuc);
        // System.Console.WriteLine($"Sau: [{string.Join(", ", soThuc)}]");
        // Array.Reverse(soThuc);
        // System.Console.WriteLine($"Sau: [{string.Join(", ", soThuc)}]");
        // System.Console.WriteLine($"a[{Array.IndexOf(soThuc, 6)}] = 6");

        // string[] tenMonHoc = ["Toan", "Ly", "Hoa", "Van", "Su"];
        // string monHocTimDuoc = Array.Find(tenMonHoc, x => x == "Toan") ?? string.Empty;
        // List<int> list = new List<int>{};

        // List<string> listString = new List<string>
        // {
        //     "Dit", 
        //     "Con",
        //     "Me",
        //     "May"
        // };
                                                    
        PaymentAccount acc = new SavingsAccount("A", 1000, 0.02m);
        System.Console.WriteLine(acc.CalculateFee(500)); 

    }
}