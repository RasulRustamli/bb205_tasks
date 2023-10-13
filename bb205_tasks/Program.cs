namespace bb205_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = null;
            bool check = true;
            do
            {

                Console.WriteLine("====== Menu ======");
                Console.WriteLine("1.Create Group");
                Console.WriteLine("2.Show all Students");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Filter Student By Name");
                Console.WriteLine("0.Exit");

                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        GroupCreate(ref group);
                        break;
                    case "2":
                        if(group!=null)
                        {
                            if(group.Students.Length>0)
                            {
                                foreach (var item in group.Students)
                                {
                                    Console.WriteLine($"Adi:{item.Name} Soyadi:{item.Surname} Point:{item.AvgPoint}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("qrupda telebe yoxdur");
                            }
                          
                        }
                        else
                        {
                            Console.WriteLine("Qrup yaratdiqdan sonra davam edin!!!!");
                        }
                        break;
                    case "3":
                        if(group!=null)
                        {
                            AddStudent(ref group);
                        }
                        else
                        {
                            Console.WriteLine("Qrup yaratdiqdan sonra davam edin!!!!");
                        }
                        break;
                    case "4":
                        if(group!=null)
                        {
                            Console.WriteLine("Axtarilan sozu daxil edin");
                            string search = Console.ReadLine();
                            Student[] students=group.FilterByName(search);
                            if(students.Length>0)
                            {
                                foreach(Student item in students)
                                {
                                    Console.WriteLine($"Adi:{item.Name} Soyadi:{item.Surname} Point:{item.AvgPoint}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bele bir telebe yoxdur");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Qrup yaratdiqdan sonra davam edin!!!!");
                        }
           

                        break;
                    case "0":
                        return;
                        default:
                        Console.WriteLine("Duzgun secim edin:");
                        break;

                }



            } while (check);
            


        }
        public static bool ChekNo(string no)
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
        public static void GroupCreate(ref Group group)
        {
            if (group == null)
            {
                bool check=true;
                do
                {
                    Console.WriteLine("Zehmet olmasa qrup numberi daxil edin");
                    string no = Console.ReadLine();
                    if (ChekNo(no))
                    {
                        GROUP:
                        Console.WriteLine("Zehmet olmasa limiti daxil edin");
                        string limit = Console.ReadLine();
                        if (int.TryParse(limit, out int studentlimit))
                        {
                            group = new Group(no, studentlimit);
                            check = false;
                            Console.WriteLine($"Group yaradildi no:{group.No}");
                        }
                        else
                        {
                            Console.WriteLine("Student limiti duzgun daxil edin");
                            goto GROUP;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Group no -i duzgun daxil edin 2 boyuk herf 3 reqem");
                    }

                } while (check);
             
            }
        }

        public static void AddStudent(ref Group group)
        {
           
                Console.WriteLine("Zehmet olmasa telebenin adini daxil edin:");
                string name = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa telebenin soyadini daxil eidn:");
                string surname = Console.ReadLine();

                Console.WriteLine("ortalamani daxil et:");
                POINT:
                string point = Console.ReadLine();
                if (int.TryParse(point, out int studentpoint))
                {
                    Student student = new Student(name, surname, studentpoint);
                    group.AddStudent(student);
                Console.WriteLine($"Telebe {group.No} nomreli qrupa elave olundu ");
                }
                else
                {
                    Console.WriteLine("ortalamani duzgun daxil et");
                    goto POINT;
                }
            
            
        }
    }

}