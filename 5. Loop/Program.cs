Random numberGenerator = new Random();

int attemps = 1;
Console.WriteLine("Press enter to roll the dice!");
Console.ReadKey();

int dice1 = numberGenerator.Next(1, 7);
int dice2 = numberGenerator.Next(1, 7);
Console.WriteLine("Dice 1 = " + dice1);
Console.WriteLine("Dice 2 = " + dice2);

while (dice1 != dice2) {
    Console.ReadKey();

    dice1 = numberGenerator.Next(1, 7);
    dice2 = numberGenerator.Next(1, 7);
    attemps++;

    Console.WriteLine("\nDice 1 = " + dice1);
    Console.WriteLine("Dice 2 = " + dice2);
}
Console.WriteLine("It took you " + attemps + " attemps to get 2 of a kind");