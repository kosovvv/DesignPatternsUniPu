using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Regimes;
public class BasicTrainingStraregy : ITrainingRegime
{
    public void Execute() => Console.WriteLine("Executing basic training.");
}
