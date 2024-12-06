using System;
using System.Windows;
using YandexTaxi;

class Program
{
    static void Main()
    {
        // Authentication attributes
        string name;
        string email;
        string password;
        int age;
        Gender gender;

        Console.WriteLine("Bus Taxi App\n");
        Console.WriteLine("\nAuthentication\n");

        Console.WriteLine("Enter your Name: ");
        name = Console.ReadLine();

        Console.WriteLine("\nEnter your Email: ");
        email = Console.ReadLine();

        Console.WriteLine("\nEnter your Password: ");
        password = Console.ReadLine();

        Console.WriteLine("\nEnter your Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter your Gender: ");
        Console.WriteLine("0. Male");
        Console.WriteLine("1. Female");
        int genderInput = Convert.ToInt32(Console.ReadLine());
        gender = (Gender)genderInput;

        Auth User = new Auth(name, email, password, age, gender);
        MessageBox.Show(User.ToString(), "User Info");
    }

}
