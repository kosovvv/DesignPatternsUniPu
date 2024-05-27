using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Programs;
class StrengthDecorator : TrainingProgramDecorator
{
    public StrengthDecorator(ITrainingProgram program) : base(program) { }

    public override string GetDescription() => $"{base.GetDescription()} + Strength exercises";
}
