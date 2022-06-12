namespace AbstraindoJogoRPG.src.Entities
{
    public class Wizard : Hero//Herda a classe Hero
    {
       
       public Wizard(string Name, int Level, string HeroType)
       {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
       }

        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }
        
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
            return this.Name + " Lançou Magia super forte com bonus de ataque de " + Bonus;
            }
            else
            {
            return this.Name + " Lançou Magia fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}