using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Regimes;
public class CardioTrainingStrategy : ITrainingRegime
{
    public void Execute() => Console.WriteLine("Executing cardio training.");
}
