// See https://aka.ms/new-console-template for more information
using System;

class Login_Exception : Exception
{
    public Login_Exception() : base()
    {}
    public Login_Exception(string message) : base(message)
    {}
}

public class Ali
{
    public static void Main()
    {
        string Password = "";
        try
        {
            Console.WriteLine("Please! Enter your Password: ");
            Password = Console.ReadLine();

            if (Password == "ALI")
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                throw new Login_Exception("Wrong Password! Try Again!");
            }
        }
        catch(Login_Exception LE)
        {
            Console.WriteLine(LE.Message);
        }
    }
}