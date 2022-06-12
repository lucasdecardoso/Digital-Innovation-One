namespace AbstraindoJogoRPG.src.Entities
{
    public abstract class Hero //abstract == É uma classe mãe, e pra ser usada precisa ser chamada por outra classe. É uma abstração do mundo para que outras classes herdem.
    {
        public Hero(string Name, int Level, string HeroType) //construtor
        {
            this.Name = Name; //this. a classe acessa variaveis dentro do objeto
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero()
        {
            
        }

        public string Name;
        public int Level;
        public string HeroType;


        public override string ToString() //override == sobrescrita de metodo, sobrescreve com novo comportamento
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack() //metodo atacar // virtual == permite que qualquer filho altere o comportamento
        {
            return this.Name + " Atacou com a sua espada";

        }

    }
}