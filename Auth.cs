using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Threading;

namespace YandexBus
{

    // Class Auth
    public class Auth
    {
        //Declared its attributes and constructor
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public Gender? gender { get; set; }

        // Constructor for Auth class with age check
        public Auth(string n, string e, string p, int a)
        {
            // used try catch and finally, it will catch depend on the error that the user will type
            try
            {
                this.name = n;
                this.email = e;
                this.password = p;
                this.age = a;

                Thread.Sleep(200);
                Console.Clear();

                Console.WriteLine("\nRegistering...");
                Thread.Sleep(1500);

                // Validate email format
                if (!IsValidEmail(e))
                {
                    throw new FormatException("Invalid email format. Please provide a valid email address.");
                }

                // Age validation
                if (a < 18)
                {
                    int future = 18 - a; // Calculate when the user can access the app
                    MessageBox.Show($"Sorry {n}, Minors aren't allowed to use Yandex app\nSee you in {future} year(s)!");
                    Environment.Exit(0);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registration Error");
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error");
                Environment.Exit(0);
            }
            finally
            {
                Console.WriteLine("Thank you for choosing our app, enjoy Yandex Taxi App");
            }

            MessageBox.Show($"Welcome {n} to our App\n", "Success");
        }

        // Overloaded constructor with gender
        public Auth(string n, string e, string p, int a, int g)
            : this(n, e, p, a)
        {
            try
            {
                // Validate gender input
                if (g != 0 && g != 1)
                {
                    // This error means if the input is out of range (the range in this case is [0,1]
                    throw new ArgumentOutOfRangeException("Gender must be 0 (male) or 1 (female).");
                }

                this.gender = (Gender)g;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gender Selection Error");
                Environment.Exit(0); // Exit on invalid gender
            }
        }

        // Overriding ToString method to display user details
        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Email: {email}\n" +
                $"Password: {password}\n" +
                $"Age: {age}\n" +
                $"Gender: {gender}\n";
        }

        // bool function to validate email format using Regex (We googled it)
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);              
        }
    }
}
