//Display a table of powers.
//Ask the user if they would like to go again, and if so loop back to the beginning.

//intro
Console.WriteLine("Welcome to the Powers Table Application!");
Console.WriteLine();

//initial loop for program

bool runWhile = true;
while (runWhile)
{
//loop for number validation
    int num = 0;
    while (num <= 0 || num > 1290)
    {
        Console.Write("Please enter an integer between 1-1290: ");
        num = int.Parse(Console.ReadLine());
    }

//Headers + right-aligned formatting

    Console.WriteLine();
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}","Number","Squared","Cubed"));
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "======", "======", "======"));

//Loop for program (countdown, square, cube)
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, i*i, i*i*i));
    }
//asking user to continue, exiting loop if not "y" or "yes"
Console.WriteLine();
Console.WriteLine("Would you like to do it again? Please choose y/n.");
string choice = Console.ReadLine().Trim().ToLower();
runWhile = choice == "y" || choice == "yes" ? true : false;

}
Console.WriteLine();
Console.WriteLine("Goodbye!");

