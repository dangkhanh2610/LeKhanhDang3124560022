namespace HelloWorld.Model;

public class Customer()
{
    private string _emailCustomer = "";

    public string EmailCustomer
    {
        get => _emailCustomer;
        set
        {
            if(value.Contains("@")) _emailCustomer = value;
        }
    } 
    public string getEmailCustomer => _emailCustomer;

    public void setEmailCustomer(string email)
    {
        _emailCustomer = email;
    } 


    public int totalincomeCustomerBIDV(int income)
    {
        //Code
        string email = _emailCustomer;
        //Additional logic can be added here
        return income;
    }
}