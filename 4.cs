using System;

public class Number{
    private int n1;
    private int n2;

    public Number(int number1, int number2){
        this.n1 = number1;
        this.n2 = number2;
    }

    public void addition(){
        int res = this.n1 + this.n2;
        Console.WriteLine("the addition is " + res);
    }

    public void subtration(){
        int res = this.n1 - this.n2;
        Console.WriteLine("the subtration is " + res);
    }

    public void multiplication(){
        int res = this.n1 * this.n2;
        Console.WriteLine("the multiplication is " + res);
    }

    public void division(){
        int res = this.n1 / this.n2;
        Console.WriteLine("the division is " + res);
    }

    public static void Main(String[] args){
        Number a_number = new Number(10, 5);
        a_number.addition();
        a_number.subtration();
        a_number.multiplication();
        a_number.division();
    }
}
