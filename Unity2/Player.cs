using System;

namespace Unity2
{
    class Player
    {
        private string name;
        private VARIANTS weapon;

        public Player()
        {
            var rand = new Random();
            this.weapon = (VARIANTS)rand.Next(0, 3);
            this.name = "Bot";
            Console.WriteLine($"{this.name} - {this.weapon}");
        }

        public Player(VARIANTS weapon, string name)
        {
            this.weapon = weapon;
            this.name = name;
            Console.WriteLine($"{this.name} - {this.weapon}");
        }

        public string WhoWins(Player a, Player b)
        {
            string result;
            //PAPER vs ROCK
            if (a.weapon == VARIANTS.PAPER && b.weapon == VARIANTS.ROCK) result = $"Победил игрок с именем: {a.name}";
            else if (b.weapon == VARIANTS.PAPER && a.weapon == VARIANTS.ROCK) result = $"Победил игрок с именем: {b.name}";
            //PAPER vs SCISSORS
            else if (a.weapon == VARIANTS.PAPER && b.weapon == VARIANTS.SCISSORS) result = $"Победил игрок с именем: {b.name}";
            else if (b.weapon == VARIANTS.PAPER && a.weapon == VARIANTS.SCISSORS) result = $"Победил игрок с именем: {a.name}";
            //ROCK vs SCISSORS
            else if (a.weapon == VARIANTS.ROCK && b.weapon == VARIANTS.SCISSORS) result = $"Победил игрок с именем: {a.name}";
            else if (b.weapon == VARIANTS.ROCK && a.weapon == VARIANTS.SCISSORS) result = $"Победил игрок с именем: {b.name}";
            else result = "Ничья!";
            return result;
        }
    }

    enum VARIANTS
    {
        PAPER, ROCK, SCISSORS
    }
}