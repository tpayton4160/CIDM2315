#nullable enable
using System;

class HumanPlayer
{
    private int points;

    // Constructor: set the human player's initial points.
    public HumanPlayer(int initial)
    {
        points = initial;
    }

    // Return the current points.
    public int GetPoints()
    {
        return points;
    }

    // Increase points by 5 when winning a round.
    public void WinRound()
    {
        points += 5;
    }

    // Decrease points by 5 when losing a round.
    public void LoseRound()
    {
        points -= 5;
    }

    // Ask the human for their decision and validate input.
    public string HumanDecision()
    {
        while (true)
        {
            Console.WriteLine("Please enter your choice (Rock, Paper, or Scissors):");
            string? decision = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(decision))
            {
                decision = decision.Trim();
                // Validate if input is one of the accepted choices.
                if (decision.Equals("Rock", StringComparison.OrdinalIgnoreCase) ||
                    decision.Equals("Paper", StringComparison.OrdinalIgnoreCase) ||
                    decision.Equals("Scissors", StringComparison.OrdinalIgnoreCase))
                {
                    return decision;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose one of the three choices: Rock, Paper, or Scissors.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}

class ComputerPlayer
{
    // Randomly choose a shape: Rock, Paper, or Scissors.
    public string ComputerDecision()
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        Random rnd = new Random();
        int index = rnd.Next(choices.Length);
        return choices[index];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        // Create the human player with initial points (e.g., 5 points).
        HumanPlayer human = new HumanPlayer(5);
        // Create the computer player.
        ComputerPlayer computer = new ComputerPlayer();

        bool keepPlaying = true;
        while (keepPlaying)
        {
            // Check if the human still has points.
            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("Game over! You have no more points.");
                break;
            }

            // Display the current points.
            Console.WriteLine("Your current points: " + human.GetPoints());

            // Get decisions from both players.
            string humanChoice = human.HumanDecision();
            string computerChoice = computer.ComputerDecision();
            Console.WriteLine("Computer chose: " + computerChoice);

            // Compare choices to determine the round outcome.
            if (string.Equals(humanChoice, computerChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It's a tie! No points awarded.");
            }
            else if (IsHumanWinner(humanChoice, computerChoice))
            {
                Console.WriteLine("You win this round!");
                human.WinRound();
            }
            else
            {
                Console.WriteLine("You lose this round!");
                human.LoseRound();
            }

            // Check if points have dropped to zero.
            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("Game over! You have no more points.");
                break;
            }

            // Ask if the player wants to continue.
            Console.WriteLine("Do you want to play another round? (Y/N)");
            string? answer = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(answer) || answer.ToUpper() != "Y")
            {
                keepPlaying = false;
            }
        }
    }

    // Helper method to determine if the human wins the round.
    // Rock beats Scissors, Scissors beats Paper, Paper beats Rock.
    static bool IsHumanWinner(string humanChoice, string computerChoice)
    {
        string humanLower = humanChoice.ToLower();
        string compLower = computerChoice.ToLower();

        if (humanLower == "rock" && compLower == "scissors")
            return true;
        if (humanLower == "scissors" && compLower == "paper")
            return true;
        if (humanLower == "paper" && compLower == "rock")
            return true;

        return false;
    }
}