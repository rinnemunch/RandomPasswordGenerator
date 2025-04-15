string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

Random rand = new Random(); 
int passwordLength = 10;
string password = ""; 

for (int i = 0; i < passwordLength; i++)
{
    int index = rand.Next(characters.Length);
    password += characters[index];
}

Console.WriteLine($"Your generated password is: {password}");   