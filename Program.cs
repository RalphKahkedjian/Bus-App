using System;
using System.Collections.Generic;
using System.Windows;
using BusApp;
using YandexBus;

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

        Console.WriteLine("\tBus Yandex App\n");
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
        int genderInput = Convert.ToInt32(Console.ReadLine());      // Convert to gender string to int using Int32
        gender = (Gender)genderInput;

        // Create an Auth object
        Auth User = new Auth(name, email, password, age, (int)gender);

        // Create a list to store booking history
        List<string> bookingHistory = new List<string>();

        // Display a MessageBox to prompt user actions
        while (true)
        {
            // Show the custom dialog (buttons)
            var dialog = new CustomDialog();
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                switch (dialog.SelectedOption)
                {
                    // TBS
                    case "Book":
                        MessageBox.Show("Book", "Book");
                        break;

                    // TBS
                    case "Display":
                        MessageBox.Show("Displaying additional information!", "Display");
                        break;

                    case "Info":
                        MessageBox.Show(User.ToString(), "User Information");
                        break;

                    case "History":
                        Console.WriteLine("\nBooking History:");
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
                MessageBox.Show("Bye! Enjoy your day. 😃", "Exit");
                break;  // Exit the loop and program
            }
        }
    }
}
