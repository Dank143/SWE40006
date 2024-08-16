using System;
using System.Windows.Forms;
using AgeLibrary;
using GenderLibrary;

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetPlaceholders();
        }

        private void SetPlaceholders()
        {
            SetPlaceholder(nameTextBox, "Enter your name");
            SetPlaceholder(ageTextBox, "Enter your age");
            SetPlaceholder(genderTextBox, "Enter your gender");

            // Attach event handlers
            nameTextBox.Enter += (sender, e) => RemovePlaceholder(nameTextBox, "Enter your name");
            nameTextBox.Leave += (sender, e) => SetPlaceholder(nameTextBox, "Enter your name");

            ageTextBox.Enter += (sender, e) => RemovePlaceholder(ageTextBox, "Enter your age");
            ageTextBox.Leave += (sender, e) => SetPlaceholder(ageTextBox, "Enter your age");

            genderTextBox.Enter += (sender, e) => RemovePlaceholder(genderTextBox, "Enter your gender");
            genderTextBox.Leave += (sender, e) => SetPlaceholder(genderTextBox, "Enter your gender");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            Greeting greeting = new Greeting();
            AgeHandler ageHandler = new AgeHandler();
            GenderHandler genderHandler = new GenderHandler();

            string name = nameTextBox.Text != "Enter your name" ? nameTextBox.Text : "";
            int age;
            string ageInput = ageTextBox.Text != "Enter your age" ? ageTextBox.Text : "";

            if (int.TryParse(ageInput, out age))
            {
                string gender = genderTextBox.Text != "Enter your gender" ? genderTextBox.Text : "";

                string greetingMessage = greeting.GetGreeting(name);
                string ageMessage = $"You are {ageHandler.GetAge(age)} years old.";
                string genderMessage = $"Your gender is {genderHandler.GetGender(gender)}.";

                greetingLabel.Text = $"{greetingMessage}\n{ageMessage}\n{genderMessage}";
            }
            else
            {
                greetingLabel.Text = "Please enter a valid age.";
            }
        }
    }
}

