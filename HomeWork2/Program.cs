//Homework
using System.Threading.Tasks;

var x = 2;
var y = 3;
var result1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
var result2 = Math.Abs(x) * Math.Sin(x);
var result3 = 2 * Math.PI * x;
var result4 = Math.Max(x,y);
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);

//New Year
var dateTimeToday = DateTime.Today;
var dateTimeNewYear =  DateTime(dateTimeToday.Year, 1, 1);
var dateTimeNewYearNext =  DateTime(dateTimeToday.Year + 1, 1, 1);
var daysNextYear = (dateTimeNewYearNext - dateTimeToday).TotalDays;
var daysThisYear = dateTimeToday.DayOfYear;
Console.WriteLine("left to the New Year");
Console.WriteLine("days passed from New Year");
