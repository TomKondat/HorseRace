namespace HorseRace
{
    public class Horse
    {
        public int ID { get; }
        public int DotsToWin { get; }
        public bool IsWinner { get; private set; }

        public Horse(int id, int dotsToWin)
        {
            ID = id;
            DotsToWin = dotsToWin;
        }

        public async Task Run()
        {
            Random rng = new Random();
            var dots = 0;
            while (dots < DotsToWin)
            {
                Console.WriteLine($"Horse {ID}: " + new string('.', dots + 1));
                dots++;
                await Task.Delay(rng.Next(100, 400));

                if (dots == DotsToWin)
                {
                    IsWinner = true;
                    break; 
                }
            }
        }
    }

}