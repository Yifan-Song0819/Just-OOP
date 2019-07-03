using System;

public class Test{
    public static void Main(String[] args){
        Vehicle vv = new Vehicle();
        vv.speed = 100;
        vv.size = 2;

        vv.move();

        Console.WriteLine(vv.speed);
        Console.WriteLine(vv.size);

        vv.setSpeed(150);
        Console.WriteLine(vv.speed);

        vv.speedUp();
        Console.WriteLine(vv.speed);

        vv.speedDown();
        Console.WriteLine(vv.speed);
    }
}

public class Vehicle{
    public double speed;
    public int size;

    public void move(){
        Console.WriteLine("Im moving!");
    }

    public void setSpeed(int newSpeed){
        this.speed = newSpeed;
    }

    public void speedUp(){
        this.speed += 10;
    }

    public void speedDown(){
        this.speed -= 20;
    }

}
