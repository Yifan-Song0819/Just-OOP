using System;

public class Person{
    public String gender;
    public int age;
    public boolean soup;

    public Person(String gender; int age; boolean soup){
        this.gender = gender;
        this.age = age;
        this.soup = soup;
    }

    public Person(String gender; int age){  //overloading
        this.gender = gender;
        this.age = age;
    }
}
