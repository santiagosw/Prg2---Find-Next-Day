int year, next_year, day, next_day, month, next_month;

Console.Clear();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.Write("Select Year" + "\n\r");
Console.Write("* Please enter the year: ");

year = int.Parse(Console.ReadLine());

Console.Write("Select Day" + "\n\r");
Console.Write("* Please enter the day: ");

day = int.Parse(Console.ReadLine());

Console.Write("Select Month" + "\n\r");
Console.Write("* Please enter the month: ");

month = int.Parse(Console.ReadLine());

if ((day == 30 && (month == 4 || month == 6 || month == 9 || month == 11)) || (day == 29 && month == 2) || (day == 28 && month == 2 && ((year % 4 != 0) || (year % 100) == 0) && (year % 400) != 0) || day == 31)
{
    next_month = month + 1;
    next_day = 1;
}
else
{
    next_day = day + 1;
    next_month = month;
}

if (next_day == 1 && next_month == 13)
{
    next_month = 1;
    next_year = year + 1;
}
else
    next_year = year;


switch (month)
{
    case 1:
        Console.WriteLine("The next DATE is: " + next_day + " January " +  next_year);
        break;

    case 2:
        Console.WriteLine("The next DATE is: " + next_day + " February " +  next_year);
        break;

    case 3:
        Console.WriteLine("The next DATE is: " + next_day + " March " +  next_year);
        break;

    case 4:
        Console.WriteLine("The next DATE is: " + next_day + " April " +  next_year);
        break;

    case 5:
        Console.WriteLine("The next DATE is: " + next_day + " May " +  next_year);
        break;
    case 6:
        Console.WriteLine("The next DATE is: " + next_day + " June " +  next_year);
        break;
    case 7:
        Console.WriteLine("The next DATE is: " + next_day + " July " +  next_year);
        break;
    case 8:
        Console.WriteLine("The next DATE is: " + next_day + " August " +  next_year);
        break;
    case 9:
        Console.WriteLine("The next DATE is: " + next_day + " September " +  next_year);
        break;
    case 10:
        Console.WriteLine("The next DATE is: " + next_day + " October " +  next_year);
        break;
    case 11:
        Console.WriteLine("The next DATE is: " + next_day + " November " +  next_year);
        break;
    case 12:
        Console.WriteLine("The next DATE is: " + next_day + " December " +  next_year);
        break;
    default:
        next_year = next_year + 1;
        Console.WriteLine("The next DATE is: " + next_day + " January " +  next_year);
        break;
}

Console.Write("End . . . " + "\n\r");
Console.Write("[ITSC Programacion 2 - Find next day]" + "\n\r");
Console.Write("Santiago Romero  - 2do año");

Console.ReadKey();