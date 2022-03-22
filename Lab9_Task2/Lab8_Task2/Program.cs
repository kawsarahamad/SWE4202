// See https://aka.ms/new-console-template for more information
using Lab9_Task2;
List<Teacher> TeacherList = new List<Teacher>();
Teacher newTeacher = new Teacher();
Console.WriteLine("Enter the Teacher Name:");
newTeacher.Name=Console.ReadLine();
Console.WriteLine("Enter the Code:");
newTeacher.code = Console.ReadLine();
Console.WriteLine("Enter the subject:");
newTeacher.subject = Console.ReadLine();
Console.WriteLine("Enter the publications:");
newTeacher.publications = Console.ReadLine();
TeacherList.Add(newTeacher);
