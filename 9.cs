using System;
public class User{
    public string ID;
    public string passwd;
    public string email;

    public User(string ID, string passwd, string email){
        this.ID = ID;
        this.passwd = passwd;
        this.email = email;
    }

    public User(string ID, string passwd){
        this.ID = ID;
        this.passwd = passwd;
        this.email = ID + "@gmail.com";
    }

    public void printInfo(){
        Console.WriteLine(this.ID + " " + this.passwd + " " + this.email);
    }

    public static void Main(String[] args){
        User a_user = new User("1", "123");
        a_user.printInfo();

        User b_user = new User("1", "123", "123@gmail.com");
        b_user.printInfo();
    }
}
