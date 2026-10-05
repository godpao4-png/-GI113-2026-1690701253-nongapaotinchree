/*
 * Student ID : 1690701253
 * Name       : Midterm-Exam
 * Section    : 129B
 * No.        : 9
 * Course     : GI113 Computer Programming (GI)
 */
namespace Mid_Term_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Minscrore = 0;
            const int Maxscore = 100;
            const int NuberOfStudents = 3;

            string playerName;
            int attackScore;
            int defenseScore;
            int ennagyScore;
            double averageScore;
            char rank;
            string playerRank;


            Console.WriteLine("=========================================: ");
            Console.WriteLine("     FIGHTER GAME SCORE RANKING SYSTEM     ");
            Console.WriteLine("=========================================: ");
            Console.Write("Please enter the player name: ");
            playerName = Console.ReadLine();

            if (playerName == null || playerName.Trim() == "")
            {
                Console.WriteLine("Invalid player name. Please try again.");
                return;
            }
            attackScore = RedScore("attack", Minscrore, Maxscore);
            defenseScore = RedScore("defense", Minscrore, Maxscore);
            ennagyScore = RedScore("ennagy", Minscrore, Maxscore);
            averageScore = (attackScore + defenseScore + ennagyScore) / 3.0;

            if (averageScore >= 90)
            {
                rank = 'A';
                playerRank = "Legendary";
            }
            else if (averageScore >= 80)
            {
                rank = 'B';
                playerRank = "Excellent";
            }
            else if (averageScore >= 70)
            {
                rank = 'C';
                playerRank = "Good";
            }
            else
            {
                rank = 'D';
                playerRank = "Needs Improvement";
            }

            Console.WriteLine("=========================================: ");
            Console.WriteLine($"Player Name: {playerName}");
            Console.WriteLine($"Attack Score: {attackScore}");
            Console.WriteLine($"Defense Score: {defenseScore}");
            Console.WriteLine($"Enemy Score: {ennagyScore}");
            Console.WriteLine($"Average Score: {averageScore:F2}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Player Rank: {playerRank}");
            Console.WriteLine("=========================================: ");

            int RedScore(string screType, int minscore, int maxscore)
            {
                int score;
                while (true)
                {
                    Console.Write($"Please enter the {screType} score ({minscore}-{maxscore}): ");
                    if (int.TryParse(Console.ReadLine(), out score) && score >= minscore && score <= maxscore)
                    {
                        return score;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid {screType} score. Please try again.");
                    }
                }
            }

        }
    }
}
