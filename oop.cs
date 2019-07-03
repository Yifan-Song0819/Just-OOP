using System;

public class OOP{
    public static void Main(String[] args){
        A a = new A();
        // Console.WriteLine(a.value);
        Console.WriteLine("Please input");
        string user_input = Console.ReadLine();
        int guess = 0;
        Int32.TryParse(user_input, out guess);
        //Console.WriteLine(guess);
        while (guess != a.value){
            if (guess > a.value){
                Console.WriteLine("Input is larger than correct number!");
            }
            else{
                Console.WriteLine("Input is smaller than correct number!");
            }
            Console.WriteLine("Please input");
            user_input = Console.ReadLine();
            guess = 0;
            Int32.TryParse(user_input, out guess);
        }
        if (guess == a.value){
            Console.WriteLine("bingo!");
        }

    }
}

class A{
    public int value = 100;
}
