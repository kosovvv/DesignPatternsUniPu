using DesignPatternsPU.Core;
using DesignPatternsPU.Interfaces;
namespace DesignPatternsPU.Participants;
class Instructor : IObservable
{
    private readonly ICollection<IObserver> observers;
    private readonly Fitness fitness;
    private string message;

    public Instructor(Fitness fitness)
    {
        this.observers = [];
        this.message = "Initial message";
        this.fitness = fitness;
    }

    public void Attach(IObserver observer) => observers.Add(observer);
    public void Detach(IObserver observer) => observers.Remove(observer);
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
    public void ChangeTrainingRegime(string newMessage)
    {
        if (fitness.IsOpen)
        {
            message = newMessage;
        }
        else
        {
            message = "Sorry, you can't train anymore. The fitness is closed";
        }
        Notify();
    }
}