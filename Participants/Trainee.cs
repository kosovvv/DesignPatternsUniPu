using DesignPatternsPU.Core;
using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Participants;
class Trainee : IObserver
{
    private readonly string name;
    private readonly Fitness fitness;
    public Trainee(string name, Fitness fitness)
    {
        this.name = name;
        this.fitness = fitness;
    }
    public void Update(string message) => Console.WriteLine($"{this.name} received update: {message}");
}