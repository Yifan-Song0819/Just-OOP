using System;

public class OOP{
    public static void Main(String[] args){
        A a = new A();

        Console.WriteLine(a.value);
        Console.WriteLine("Please input");
        string user_input = Console.ReadLine();
        Console.WriteLine(user_input);
    }
}

class A{
    public int value = 100;
}
