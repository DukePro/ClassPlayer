namespace Programm
{
    class MyProgramm
    {
        static void Main()
        {
            Player player = new Player();

            player.ShowStatus();
        }
    }

    class Player
    {
        public int Health;
        public int Damage;

        public Player(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public Player()
        {
            Health = 100;
            Damage = 10;
        }
    
        public void ShowStatus()
        {
            Console.WriteLine("Health: " + Health + "\nDamage: " + Damage);
        }
    }
}