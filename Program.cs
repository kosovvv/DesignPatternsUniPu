using DesignPatternsPU.Interfaces;
using DesignPatternsPU.Programs;
using DesignPatternsPU.Regimes;
using DesignPatternsPU.Participants;
using DesignPatternsPU.Core;

Fitness gym = Fitness.GetInstance;

gym.Name = "Healthy Gym";


Instructor instructor = new Instructor(gym);

gym.AddInstructor(instructor);

Trainee trainee1 = new("John", gym);
Trainee trainee2 = new("Jane", gym);

gym.AddTrainee(trainee1, trainee2);


instructor.Attach(trainee1);
instructor.Attach(trainee2);

gym.Open();

instructor.ChangeTrainingRegime("New training regimen available!");

TrainingContext context = new();

context.SetTrainingRegime(new BasicTrainingStraregy());
context.ExecuteTraining();

context.SetTrainingRegime(new CardioTrainingStrategy());
context.ExecuteTraining();

ITrainingProgram basicProgram = new BasicProgram();
ITrainingProgram cardioProgram = new CardioDecorator(basicProgram);
ITrainingProgram fullProgram = new StrengthDecorator(cardioProgram);

Console.WriteLine(fullProgram.GetDescription());

//gym.Close();

//instructor.ChangeTrainingRegime("New traidning regimen available!");
