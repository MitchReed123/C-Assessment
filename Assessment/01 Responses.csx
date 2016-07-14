using System;


// Part One - Basics

int i = 5;

bool b = false;

string s = "I have been at ElevenFifty for ";

string t = " weeks.";

double dbl = 7.80f;

decimal d1 = 2.5M;

string yes = s + d1 + t ;

Console.WriteLine(yes);


var friendsNames = new string[3];

friendsNames[0] = "Ali";
friendsNames[1] = "Pat";
friendsNames[2] = "Patrick";







// Part Two - OOP
public enum Gender { Unknown, Male, Female };
public class Customer
{
    private string _Name;
    private string _Purchase;
    private Gender _Gender;
    private int _Date;
    private string info;

    public Customer(string name, Gender gender, string purchase)
    {
        Name = name;
        Gender = gender;
        Purchase = purchase;
    }

    public void ThankYou(string Name, string Purchase)
    {
        Console.WriteLine($"Hello {Name}, thank you for purchasing the {Purchase}. We hope you enjoy it!");
    }

    public String Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public String Purchase
    {
        get { return _Purchase; }
        set { _Purchase = value; }
    }
    public Gender Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    public void SendSaleNotice(int Date = 7/4/16)
    {
        Console.WriteLine($"Hello Dave, We wanted to let you know there's a sale coming up on {Date}");
    }
    public void SendSaleNotice(int Date = 7 / 4 / 16, string message = "Apple iPhones coming up on ")
    {
        Console.WriteLine($"Hello Dave, We wanted to let you know there's a sale on{message} {Date}");
    }

    public virtual string PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Purchase} - {Gender}");
    }



}
public class InactiveCustomer
       : Customer
{
    private int _MonthsInactive;
    public enum ReasonsForInactivity { Irate, Moved, Uninterested }
    private ReasonsForInactivity _reasons;
    public InactiveCustomer(string name, Gender gender, string purchase, int monthsInactive)
        : base(name,gender,purchase)
    {
        Console.WriteLine($"Thanks for shopping with us {Name}. We saw that you purchased an {Purchase} from us {monthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals");
    }


    public int monthsInactive
    {
        get { return _MonthsInactive; }
        set { _MonthsInactive = value; }
    }

    public ReasonsForInactivity reasons
    {
        get { return _reasons; }
        set { _reasons = value; }
    }
    public override string PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Purchase} - {Gender} - {reasons}");
    }
}



