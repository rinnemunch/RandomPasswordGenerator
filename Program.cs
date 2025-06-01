bool keepRunning = true;

while (keepRunning)
{
    string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    Random rand = new Random();
    int passwordLength = 10;
    string password = "";

    for (int i = 0; i < passwordLength; i++)
    {
        int index = rand.Next(characters.Length);
        password += characters[index];
    }

    string masked = new string('*', password.Length);
    Console.WriteLine($"Your generated password is: {masked}");

    Console.Write("Reveal password? (y/n): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "y")
    {
        Console.WriteLine($"Revealed password: {password}");
    }
    else
    {
        Console.WriteLine("Password hidden. Stay safe.");
    }

    Console.Write("Want to test your own password? (y/n): ");
    string testInput = Console.ReadLine();

    if (testInput.ToLower() == "y")
    {
        Console.Write("Enter your password: ");
        string userPassword = Console.ReadLine();

        bool hasLetter = false;
        bool hasDigit = false;
        bool hasSpecial = false;

        foreach (char c in userPassword)
        {
            if (char.IsLetter(c)) hasLetter = true;
            else if (char.IsDigit(c)) hasDigit = true;
            else hasSpecial = true;
        }

        string strength = "Weak";

        if (userPassword.Length >= 10 && hasLetter && hasDigit && hasSpecial)
            strength = "Strong";
        else if (userPassword.Length >= 8 && hasLetter && hasDigit)
            strength = "Medium";

        Console.WriteLine($"Your password strength is: {strength}");
    }

    Console.Write("Generate another password? (y/n): ");
    string again = Console.ReadLine();
    if (again.ToLower() != "y")
    {
        keepRunning = false;
        Console.WriteLine("Have a great day.");
    }
}
