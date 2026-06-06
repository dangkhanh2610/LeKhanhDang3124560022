class UserInfo
{
    private string username = "";
    private string password = "";

    public UserInfo(){}
    public UserInfo(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
    public string Username
    {
        get => username;
        set
        {
            username = value;
        }
    }

    public string Password
    {
        get => password;
        set
        {
            password = value;
        }
    }

    public override string ToString()
    {
        return $"User: {username} - Password: {password}"; 
    }   


}