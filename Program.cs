using System;
using System.Windows;
using BusApp;
using YandexTaxi;

class Program
{
    [STAThread] // Required to be able to use the event handles in the Buttons.xaml file
    static void Main()
    {
        // Authentication attributes
        string name;
        string email;
        string password;
        int age;
        Gender gender;

        Console.WriteLine("\tBus Taxi App\n");
        Console.WriteLine("\nAuthentication");
        Console.WriteLine("-----------------------\n");

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

        // Create an Auth object
        Auth User = new Auth(name, email, password, age, (int)gender);

        // Display a MessageBox to prompt user actions
        while (true)
        {
            // Show the custom dialog
            var dialog = new CustomDialog();
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                switch (dialog.SelectedOption)
                {
                    case "Book":
                        MessageBox.Show("Booking process started!", "Book");
                        break;

                    case "Display":
                        MessageBox.Show("Displaying additional information!", "Display");
                        break;

                    case "View":
                        MessageBox.Show(User.ToString(), "User Information");
                        break;

                    case "Close":
                        MessageBox.Show("Exiting the program\nHave a nice day", "Exit");
                        Environment.Exit(0);  // Close the application
                        break;

                    default:
                        MessageBox.Show("Unknown action.", "Error");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Exiting...", "Exit");
                break;  // Exit the loop and program
            }
        }
    }
}
