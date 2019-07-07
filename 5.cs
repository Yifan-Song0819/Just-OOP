using System;

public class Person{
    private string name;
    private int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    public void display(){
        Console.WriteLine("This man's name is " + this.name + ", and age is " + this.age + ".");
    }

    public static void Main(String[] args){
        Person a_Person = new Person("James Song", 29);
        a_Person.display();
    }
}
