using DesignPatternsPU.Participants;

namespace DesignPatternsPU.Core
{
    class Fitness
    {
        private static Fitness? instance = null;
        private static readonly object lockObj = new();
        private bool isOpen;
        private ICollection<Trainee> trainees;
        private ICollection<Instructor> instructors;

        private Fitness() 
        {
            this.trainees = new HashSet<Trainee>();
            this.instructors = new HashSet<Instructor>();
            this.isOpen = false;
        }

        public string Name { get; set; }
        public bool IsOpen => isOpen;

        public void AddTrainee(params Trainee[] trainees)
        {
            foreach (var trainee in trainees)
            {
                this.trainees.Add(trainee);
            }
        }

        public void AddInstructor(params Instructor[] instructors)
        {
            foreach(var instructor in instructors)
            {
                this.instructors.Add(instructor); 
            }
        }

        public void Open()
        {
            isOpen = true;
            foreach (var instructor in instructors)
            {
                instructor.ChangeTrainingRegime("Fitness is opening.");
            }
        }
        public void Close()
        {
            foreach (var instructor in instructors)
            {
                instructor.ChangeTrainingRegime("Fitness is closing.");
            }
            isOpen = false;
        }

        public static Fitness GetInstance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null) instance = new Fitness();
                    return instance;
                }
            }
        }    
    }
}
