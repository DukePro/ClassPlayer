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
        private int _health;
        private int _damage;

        public Player(int health, int damage)
        {
            _health = health;
            _damage = damage;
        }

        public Player()
        {
            _health = 100;
            _damage = 10;
        }
    
        public void ShowStatus()
        {
            Console.WriteLine("Health: " + _health + "\nDamage: " + _damage);
        }
    }
}