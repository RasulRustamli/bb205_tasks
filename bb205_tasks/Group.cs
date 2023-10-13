namespace bb205_tasks
{
    internal class Group
    {
        private string _no;
        public string No
        {
            get { return _no; }
            set
            {
                if (ChekNo(value))
                {

                    _no = value;
                }
            }
        }
        public int StudentLimit { get; set; }
        public Student[] Students;

        public Group(string no,int limit)
        {
            No = no;
            StudentLimit = limit;
            Students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students,Students.Length+1);
            Students[Students.Length-1] = student;
        }
        public Student[] FilterByName(string search)
        {
            Student[] filterStudent=new Student[0];
            for(int i=0;i<Students.Length;i++)
            {
                //string fulname = Students[i].Name + " " + Students[i].Surname;
                if($"{Students[i].Name} {Students[i].Surname}".ToLower().Contains(search))
                {
                    Array.Resize(ref filterStudent, filterStudent.Length + 1);
                    filterStudent[filterStudent.Length-1]=Students[i];
                }
            }
            return filterStudent;
        }



        public bool ChekNo(string no)
        {
            if (char.IsUpper(no[0]) && char.IsUpper(no[1]) && no.Length == 5)
            {
                for (int i = 2; i < 5; i++)
                {
                    if (!char.IsDigit(no[i]))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;

        }
    }
}
