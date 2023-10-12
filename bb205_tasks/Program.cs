namespace bb205_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "filankes",
                Surname = "filankesov",
                AvgPoint = 25
            }; 
            Student student2 = new Student()
            {
                Name = "Hikmet",
                Surname = "Adilov",
                AvgPoint = 25
            };
            Student student3 = new Student()
            {
                Name = "Isgender",
                Surname = "Abbasov",
                AvgPoint = 25
            };

            Group group = new Group()
            {
                No = "BB205",
                StudentLimit = 6
            };

            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);


            foreach (var item in group.FilterByName("il"))
            {
                Console.WriteLine(item.Name+" "+item.Surname);
            }



        }
    }
}