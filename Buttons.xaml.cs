using System.Windows;

namespace BusApp
{
    public partial class CustomDialog : Window
    {
        public string SelectedOption { get; private set; }

        public CustomDialog()
        {
            InitializeComponent();
        }

        // Event handler for Book button
        private void Book_Click(object sender, RoutedEventArgs e)
        {
            SelectedOption = "Book";
            this.DialogResult = true;  // Close the dialog and return true
        }

        // Event handler for Display button
        private void Display_Click(object sender, RoutedEventArgs e)
        {
            SelectedOption = "Display";
            this.DialogResult = true;  // Close the dialog and return true
        }

        // Event handler for User Info button
        private void UserInfo_Click(object sender, RoutedEventArgs e)
        {
            SelectedOption = "User Info";
            this.DialogResult = true;  // Close the dialog and return true
        }

        // Close Program button event
        private void CloseProgram_Click(object sender, RoutedEventArgs e)
        {
            SelectedOption = "Close Program";
            this.DialogResult = false;  // Ensure the dialog closes without returning a result
        }
    }
}
