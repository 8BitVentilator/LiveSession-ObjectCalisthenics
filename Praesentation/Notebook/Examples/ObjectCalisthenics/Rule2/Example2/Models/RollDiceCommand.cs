namespace ObjectCalisthenics.Rule2.Example2.Models;

public class RollDiceCommand : ICommand
{
    public void Execute() => Console.WriteLine(new Random().Next(1, 6 + 1));
}
