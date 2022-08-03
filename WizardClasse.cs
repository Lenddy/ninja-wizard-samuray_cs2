namespace classes;
public class Wizard : Human
{

    public Wizard(string name, int str ,int dex, int intel = 25, int hp = 50) : base(name, str,intel, dex,hp)
    {
    }

// this is to override the attack method in human class you need to add the virtual key word after public in the human method
    public override int   Attack(Human target){
        int damage = Intelligence * 5;
        target.Health -= damage;
        Health  += damage;
        return target.Health;
    }

    public int Heal(Human target){
        target.Health += 10 * Intelligence;
        return target.Health;
    }
}
