Console.WriteLine("Enter day of the week");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
    Console.WriteLine("Today is Monday. Today is a working day");
    break;

    case 2:
    Console.WriteLine("Today is Tuesday. Today is a working day");
    break;

    case 3:
    Console.WriteLine("Today is Wensday. Today is a working day");
    break;

    case 4:
    Console.WriteLine("Today is Thursday. Today is a working day");
    break;

    case 5:
    Console.WriteLine("Today is Friday. Today is a working day");
    break;

    case 6:
    Console.WriteLine("Today is Saturday. Today is a day off ");
    break;

    case 7:
    Console.WriteLine("Today is Sunday. Today is a day off");
    break;

    default:
    Console.WriteLine("Invalid value of day of the week");
    break;
}
