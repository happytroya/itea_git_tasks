namespace Heroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warrior = new Warrior() { Name = "Ivan", Weapon = "Sword", Damage = 100 };
            var archer = new Archer() { Name = "Legolas", Weapon = "Arch", Damage = 50 };


            var warriorController = new HeroController<Warrior>(warrior);
            var archerConrtoller = new HeroController<Archer>(archer);

            warriorController.ForceToAttack();
            archerConrtoller.ForceToAttack();

        }
    }
}