﻿using System.Diagnostics;

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
Console.WriteLine(weekDay);

switch (weekDay)
{
	case 0:
		Console.WriteLine("Sunday");
		break;
	case 1: Console.WriteLine("Monday");
		break;
	case 2: Console.WriteLine("Thuesday");
		break;
	case 3: Console.WriteLine("Wednesday");
		break;
	case 4: Console.WriteLine("Thursday");
		break;
	case 5: Console.WriteLine("Friday");
		break;
	case 6: Console.WriteLine("satusday");
		break;
	default:
		Console.WriteLine("Invalid vakue");
		break;

}
