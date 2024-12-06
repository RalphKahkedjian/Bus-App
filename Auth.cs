using System;
using System.Windows;

namespace YandexTaxi
{
    public class Auth
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public Gender? gender { get; set; }

        // Constructor for Auth class with age check
        public Auth(string n, string e, string p, int a)
        {
            this.name = n;
            this.email = e;
            this.password = p;
            this.age = a;

            if (a < 18)
            {
                int future = 18 - a;  // Calculated when can the user have access to our app ( just for fun )
                MessageBox.Show($"Sorry {n}, Minors aren't allowed to use Yandex app\nMaybe see you {future} year/s later !");
                Environment.Exit(0);  // The user can't continue accessing our app if he's a minor
            }

            MessageBox.Show($"Welcome {n} to our App\n", "Success");
        }

        // Overloaded constructor with gender
        public Auth(string n, string e, string p, int a, Gender g)
            : this(n, e, p, a)
        {
            this.gender = g;
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
    }

    // Enum for Gender
    public enum Gender
    {
        male,
        female
    }
}