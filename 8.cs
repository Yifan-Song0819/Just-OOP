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

    // add another class variable seats, and initialize in the constructor
    public Car(string brand, string color, int seats) : base(brand, color){
        this.brand = brand;
        this.color = color;
        this.seats = seats;
    }

    public void showCar(){
        Console.WriteLine("this car has a " + this.color + " color and its brand is " + this.brand +" and " + this.seats + " seats.");
    }
}

public class Truck : Vehicles{
    public float load;

    public Truck(string brand, string color, float load) : base(brand, color){
        this.brand = brand;
        this.color = color;
        this.load = load;
    }


    public void showTruck(){
        Console.WriteLine("this truck has a " + this.color + " color and its brand is " + this.brand +"." + this.load);
        // Console.WriteLine(this.brand);
    }
}

public class Test{
    public static void Main(String[] args){
        Car a_car = new Car("toyota", "red", 5);
        a_car.showCar();


        Truck a_truck = new Truck("ranger", "blue", 18);
        a_truck.showTruck();

    }
}
