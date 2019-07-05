using System;

public class Test{
    public static void Main(String[] args){
        MyTime aTime = new MyTime(22,11,14);
        aTime.display();
    }
}


public class MyTime{
    private int hour;
    private int minute;
    private int second;

    public MyTime(int iniHour, int iniMinute, int iniSecond){
        this.hour = iniHour;
        this.minute = iniMinute;
        this.second = iniSecond;
    }

    public void display(){
        Console.WriteLine("Current Time is " + this.hour + ":" + this.minute + ":" + this.second);
    }

    public void addSecond(int sec){
        this.second += sec;
    }

    public void addMinute(int min){
        this.minute += min;
    }

    public void addHour(int hou){
        this.hour += hou;
    }

    public void subSecond(int sec){
        this.second -= sec;
    }

    public void subMinute(int min){
        this.minute -= min;
    }

    public void subHour(int hou){
        this.hour -= hou;
    }
}
