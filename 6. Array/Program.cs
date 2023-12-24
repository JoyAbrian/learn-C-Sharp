Console.Write("How many students are in your class: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] students = new string[length];
Console.WriteLine("Please input the names of the students");

for (int i = 0; i < students.Length; i++) {
    students[i] = Console.ReadLine();
}

Array.Sort(students);
Console.WriteLine("------------------");

for (int i = 0; i < students.Length; i++) {
    Console.WriteLine(students[i]);
}