using System.Security.AccessControl;
using HelloWorld.Model;

namespace HelloWorld.Service;

public class BankCustomer
{
    public string _nameCustomer {get; set;} = "";
    private decimal _balanceCustomer;
    

    public decimal BalanceCustomer
    {
        get => _balanceCustomer;
        set
        {
            if(value >= 0) _balanceCustomer = value;
        }
    }

    public BankCustomer() {}
    public BankCustomer (string nameCustomer, decimal balanceCustomer)
    {   
        _nameCustomer = nameCustomer;
        _balanceCustomer = balanceCustomer;
    }
    
}