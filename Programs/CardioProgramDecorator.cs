using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Programs;
class CardioDecorator : TrainingProgramDecorator
{
    public CardioDecorator(ITrainingProgram program) : base(program) { }

    public override string GetDescription() => $"{base.GetDescription()} + Cardio exercises";
}
