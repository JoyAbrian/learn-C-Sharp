Console.WriteLine("Question 1\n 1 + 2 + 3 = ?");
int answer = Convert.ToInt32(Console.ReadLine());

if (answer == 6) {
    Console.WriteLine("Correct!");
    Console.WriteLine("Question 2\n 5! = ?");
    answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 120) {
        Console.WriteLine("Correct!");
        Console.WriteLine("You Answer all question right");
    } else {
        Console.WriteLine("WRONG ANSWER!!");
        Console.WriteLine("You answered 1 question right");
    }
} else {
    Console.WriteLine("WRONG ANSWER!!");
}