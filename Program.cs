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
