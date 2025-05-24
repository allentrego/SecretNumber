
// generate a random number between 1 and 100
int randomNumber = new Random().Next(1, 101);

// ask the player to guess the number
Console.WriteLine("Guess a number between 1 and 100: ");

// read the player's guess
int playerGuess = Convert.ToInt32(Console.ReadLine());

