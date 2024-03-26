namespace arena
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            
            Fighter participant1 = new Fighter(10, 5, "xc");
            Archer participant2 = new Archer(9, 5, "hibs");
            Mage participant3 = new Mage(11, 5, "ted");

            Arena arena = new Arena();
            arena.AddParticipant(participant1);
            arena.AddParticipant(participant2);
            arena.AddParticipant(participant3);
            arena.PlayAction();
        }
    }
}


/*
 * We are making a fighting arena 
 * 
 * We need a class Fighter that can F. Attack(int damage) , the Fighter has (int)Health and (int) Range and (string)TypeOfSword
 * We need a class Archer that can F. Attack(int damage) , the Archer has Health and Range and TypeOfBow
 * We need a class Mage that can Attack(int damage) , the Mage has Health and Range and TypeOfSpells
 * 
 * Our arena is consist of List of our Participants
 */