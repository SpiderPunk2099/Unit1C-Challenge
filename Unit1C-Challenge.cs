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