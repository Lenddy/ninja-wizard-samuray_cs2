using classes;
Wizard Lenddy =new Wizard("Lenddy",5,5);
Human kenia = new Human("kenia");

Console.WriteLine($"{Lenddy.Name} attack {kenia.Name} and her hp in now {Lenddy.Attack(kenia)}");
Console.WriteLine($" {kenia.Name} hp is heal  to {Lenddy.Heal(kenia)}");
