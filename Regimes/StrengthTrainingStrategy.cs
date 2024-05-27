using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Regimes;
public class StrengthTrainingStrategy : ITrainingRegime
{
    public void Execute() => Console.WriteLine("Executing strength training.");
}