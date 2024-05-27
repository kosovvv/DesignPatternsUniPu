using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Programs;
abstract class TrainingProgramDecorator : ITrainingProgram
{
    protected ITrainingProgram trainingProgram;

    public TrainingProgramDecorator(ITrainingProgram program)
    {
        trainingProgram = program;
    }

    public virtual string GetDescription() => trainingProgram.GetDescription();
}