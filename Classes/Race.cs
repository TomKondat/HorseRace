using HorseRace.Validators;

namespace HorseRace.Classes
{
    public class Race
    {
        private List<Horse> _horses;

        public Race()
        {
            var numOfHorses = ValidateNumbers.ValidateHorseNumber();
            var dotsToWin = ValidateNumbers.ValidateDotsToWin();

            _horses = new List<Horse>();
            for (int id = 1; id <= numOfHorses; id++)
            {
                var horse = new Horse(id, dotsToWin);
                _horses.Add(horse);
            }
        }

        public async Task StartRace()
        {
            Console.WriteLine("The race begins!");

            var raceTasks = new List<Task>();
            foreach (var horse in _horses)
            {
                raceTasks.Add(horse.Run());
            }

            await Task.WhenAny(raceTasks);
        }

        public Horse GetWinner()
        {
            foreach (var horse in _horses)
            {
                if (horse.IsWinner)
                {
                    return horse;
                }
            }
            return null;
        }
    }
}