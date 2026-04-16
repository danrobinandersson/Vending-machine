# Vending-machine: Kebabomaten

📌 Description

This project is a simple console-based vending machine built in C# using object-oriented programming (OOP).

The application allows a user to:

View available products
Buy products (if they have enough money)
See purchased items
Check remaining money

The program runs in a loop and interacts with the user through a text-based menu.

🧱 Project Structure

The project is divided into several classes:

🧍 User

Represents the user of the vending machine.

Stores the user's name and available money
Keeps track of purchased items
Handles spending money and adding items

🥤 Product

Represents a product in the vending machine.

Contains a name and a price
🏪 VendingMachine

Represents the vending machine.

Stores a list of products
Displays available products
Retrieves products safely based on user selection

📦 SeedData

Provides initial data (products) for the vending machine.

▶️ Program

The main entry point of the application.
Handles user interaction
Displays the menu
Connects all classes together

⚙️ Features
Menu-driven interface
Input validation using TryParse
Prevents invalid selections
Prevents purchases without enough money
Displays purchased items
Shows remaining balance
Clean console UI using Console.Clear()

▶️ How to Run
Open the project in Rider or Visual Studio
Build the project
Run the application
Follow the on-screen menu
