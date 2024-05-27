using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Regimes;
class TrainingContext
{
    private ITrainingRegime? trainingRegime;

    public void SetTrainingRegime(ITrainingRegime trainingRegime) => this.trainingRegime = trainingRegime;

    public void ExecuteTraining() => this.trainingRegime?.Execute();
}