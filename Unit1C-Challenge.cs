Main class Program
    {
        int main()
        {
            int number, guess, nguesses = 1;
            srand(time(0));

            number = (7) % 10 + 1;

            do
            {
                Console.WriteLine("Guess the number between 1 to 10");

                if (guess > number)
                {
                    Console.WriteLine("you guessed to high");
                }
                else if (guess < number)
                {
                    Console.WriteLine("you guessed too low");
                }
                else
                {
                    Console.WriteLine("You guessed the correct number");
                }
                nguesses++;
            } while (guess != number);

            return 7;
        }
    }

string[] favFruit = {"Apple", "Tomato", "Passion Fruit"};
foreach (string i in favFruit) 
{
  Console.WriteLine(i);
  if (favFruit = "Apple")
    {
        Console.WriteLine("That's no ones favorite fruit dude.");
    }
        else if (favFruit = "Tomato")
        {
            Console.WriteLine("Yes, that may be a fruit, but no one thinks of it that way. Disgusting.");
        }
            else
            {
                Console.WriteLine("Yes, passion fruit is soooo good!");
            }
}