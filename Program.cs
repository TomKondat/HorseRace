namespace HorseRace
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var numOfHorses = 5;
            var dotsToWin = 20;

            var horses = new List<Horse>();
            for (int id = 1; id <= numOfHorses; id++)
            {
                Horse horse = new Horse(id, dotsToWin);
                horses.Add(horse);
            }

            Console.WriteLine("The race begins!");

            var raceTasks = new List<Task>();

            foreach (var horse in horses)
            {
                raceTasks.Add(horse.Run());
            }

            await Task.WhenAny(raceTasks);

            var winner = horses.FirstOrDefault(horse => horse.IsWinner);

            Console.WriteLine($"Horse {winner.ID} wins the race!");
        }

    }
}