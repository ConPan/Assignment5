// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void MyFifthMethod(string firstName, string lastName)
    {
        Console.WriteLine(lastName + ", " + firstName);
    }


    // No Main

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your firstName");
        string userfirstName = Console.ReadLine();
        Console.WriteLine("Please enter your lastName");
        string userlastName = Console.ReadLine();
        MyFifthMethod(userfirstName, userlastName) ;

    }
}
