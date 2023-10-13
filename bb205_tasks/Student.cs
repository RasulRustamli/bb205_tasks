namespace bb205_tasks
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _avgPoint;

        public Student(string name, string surname, int avgPoint)
        {
            Name = name;
            Surname = surname;
            AvgPoint = avgPoint;
        }

        public int AvgPoint
        {
            get { return _avgPoint; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _avgPoint = value;
                }
            }
        }

    }
}
