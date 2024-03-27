using HorseRace.Classes;
using HorseRace.Validators;

namespace HorseRace
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var race = new Race();

            await race.StartRace();

            var winner = race.GetWinner();

            Console.WriteLine($"Horse {winner.ID} wins the race!");
        }

    }
}