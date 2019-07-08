using System;

public class Person{
    private String name;

    public Person(String name){
        this.name = name;
    }

    public String getName(){
        return this.name;
    }

    public void setName(string newName){
        this.name = newName;
    }

    public static void Main(String[] args){
        Person a_guy = new Person("James");
        Console.WriteLine(a_guy.getName());

        a_guy.setName("Austin");
        Console.WriteLine(a_guy.getName());
    }
}
