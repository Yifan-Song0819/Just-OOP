using System;

public class Vehicles{
    public string brand;
    public string color;

    public Vehicles(string brand, string color){
        this.brand = brand;
        this.color = color;
    }

    public void run(){
        Console.WriteLine("Im running!");
    }

    public void showInfo(){
        Console.WriteLine("Im a " + this.color + " car and my brand is " + this.brand +".");
    }
}

public class Car : Vehicles{
    public int seats;

    public Car(string brand, string color) : base(brand, color){
        this.brand = brand;
        this.color = color;
    }

    public void showCar(){
        Console.WriteLine("this car has a " + this.color + " car and its brand is " + this.brand +".");
    }
}

public class Truck : Vehicles{
    public float seats;

    public Truck(string brand, string color) : base(brand, color){
        this.brand = brand;
        this.color = color;
    }

    public void showTruck(){
        Console.WriteLine("this truck has a " + this.color + " car and its brand is " + this.brand +".");
    }
}

public class Test{
    public static void Main(String[] args){
        Car a_car = new Car("toyota", "red");
        a_car.showCar();
    }
}
