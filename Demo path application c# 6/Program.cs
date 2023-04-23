// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Please enter your first name");
//string firstname = Console.ReadLine();

//Console.WriteLine("Please enter your last name");
//string lastname = Console.ReadLine();

//Console.WriteLine("Hello" + " " + firstname + " " + lastname);

//int intMaxValue = int.MaxValue;
//int intMinValue = int.MinValue;

//char userSelection = 'a';
//char upperVersion = char.ToUpper(userSelection);
//bool isDigit = char.IsDigit(upperVersion);
//bool isLetter = char.IsLetter(upperVersion);


//Console.ReadLine();


//DateTime employeesStartDate = new DateTime(2025, 03, 28);
//DateTime today = DateTime.Today;
//DateTime twoDaysLater = DateTime.Today.AddDays(10);
//DayOfWeek day = DateTime.Today.DayOfWeek;
//bool isDST = DateTime.Today.IsDaylightSavingTime();


//DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 45);
//Console.WriteLine(hireDate);

//DateTime exitDate = new DateTime(2015, 12, 11);

////DateTime invalidDate = new DateTime(2025, 15, 11);

//DateTime startDate = hireDate.AddDays(15);
//Console.WriteLine(startDate);

//DateTime currentDate = DateTime.Now;
//bool areWeInDst = currentDate.IsDaylightSavingTime();



//Calculate start hour and end hour
//DateTime starthour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = starthour.Add(workTime);

//Console.WriteLine(starthour.ToLongDateString());
//Console.WriteLine(endHour.ToShortTimeString());

//Console.ReadLine();



// if statement 
//int age = 18;
//if (age > 18)
//    Console.WriteLine("you eligible for voting ");
//else
//    Console.WriteLine("You are not eligible for voting");

//if (age > 18)
//    Console.WriteLine("you eligible for voting ");
//    Console.WriteLine("Because your age above of 18");
////we are need to curly braces here  !

//else
//    Console.WriteLine("You are not eligible for voting");


//using an else if block
//int age = 18;
//if (age < 18)
//    Console.WriteLine("To Young to apply");
//else if (age > 65)
//    Console.WriteLine("Sorry, the selected age is to old");
////this condition not checked this way according to me condition (age<18 && age>65) this condition properly work
//else
//    Console.WriteLine("Great, you can continue!");

//Console.WriteLine("Enter the age of the new candidate: ");
//int age = int.Parse(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("Too young to apply");
//    Console.WriteLine("Send mail to candidate.");
//}
//else
//{
//Console.WriteLine("Great, you can now start with the application!");
//}

//DateTime todays = DateTime.Now;
//bool endOfMonthPaymentStarted = false;

//if (todays.Date.Day == 20)
//{
//    Console.WriteLine("Please start end-of-month employee payments");
//}
//else if (todays.Date.Day >= 25 && !endOfMonthPaymentStarted)
//{
//    Console.WriteLine("Payment will be late!");
//}
//else isn't required!

//int age = int.Parse(Console.ReadLine());

//switch (age)
//{
//    case < 18:
//        Console.WriteLine("Too young to apply");
//        break;
//    case > 65:
//        Console.WriteLine("Sorry, the selected age too old");
//        break;
//    case 23:
//        Console.WriteLine("Wow,exactly what we are looking for");
//        break;
//    default:
//        Console.WriteLine("Great, you can continue");
//        break;
//}

//Console.ReadLine();


//Console.WriteLine("Chose the action you want to do: ");
//Console.WriteLine("1. Add employee");
//Console.WriteLine("2. Update employee");
//Console.WriteLine("3. Delete employee");

//string selectaction = Console.ReadLine();

//switch (selectaction)
//{
//    case "1":
//        Console.WriteLine("Add new employee");
//        break;
//    case "2":
//        Console.WriteLine("Updating employee");
//        break;
//    case "3":
//        Console.WriteLine("Deleting employee");
//        break;
//    default:
//        Console.WriteLine("Invalid input");
//        break;
//}


// Loop in C#

//1.while loop

//int i = 0;
//while (i < 10)
//{
//  Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine("Enter a value:");
//int max=int.Parse(Console.ReadLine());
//int i = 0;
//while (i < max)
//{
//    Console.WriteLine(i);
//        i++;
//}
//Console.WriteLine("Loop finished!");



//Console.WriteLine("Chose the action you want to do: ");
//Console.WriteLine("1. Add employee");
//Console.WriteLine("2. Update employee");
//Console.WriteLine("3. Delete employee");
//Console.WriteLine("99. Exit application");
//string selectaction = Console.ReadLine();

//while (selectaction !="99")
//{
//    switch (selectaction)
//    {
//        case "1":
//            Console.WriteLine("Add new employee");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee");
//            break;
//        default:
//            Console.WriteLine("Invalid input");
//            break;
//    }

//    Console.WriteLine("Chose the action you want to do: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//     selectaction = Console.ReadLine();
//}






//int i = 0;
//int j = 0;
//while (i < 10)
//{
//    while (j < 10)
//    {
//        Console.WriteLine("i:"+i+"j:" + j);
//       j++;
//    }
//    j = 0;
//    i++;
//}

//while (true)
//{
//   Console.WriteLine(DateTime.Now);
//}


//Creating a do-while loop 

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}while (i<10);



//Creating a for-loop


//for (initialization; Boolean; iterator)
//{
//    //statement
//}


//int sum = 0;
//for(int i = 0; i < 10; i++)
//{
//    //sum=sum+i;
//    sum += i;
//}
//Console.WriteLine(sum);



//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());

//for (int i = 0; i < max; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine("Bingo!" + i + "was found!");
//        continue;
//    }
//    Console.WriteLine(i);
//}


//int f = 1;
//int n = int.Parse(Console.ReadLine());
//int i;
//for (i = 1; i <= n; i++)
//{
//    f = f * i;

//}
//Console.WriteLine("This is factorial value:" + f);



using Demo_path_application_c__6;

//int amount = 1234;
//int month = 12;
//int bonus = 1000;
//CalculateYearlyWage(amount, month);
//int yearlyWage= utilities.CalculateYearlyWage(amount, month, bonus);
//Console.WriteLine($"Yearly wage:{yearlyWage}");
//Console.ReadLine();

//static void CalculateYearlyWage(int monthlyWage,int numberOfMonthworked)
//{
//    Console.WriteLine($"Yearly wage:{monthlyWage*numberOfMonthworked}");
//}

//static int CalculateYearlyWage(int monthlyWage, int numberOfMonthworked)
//{
//    return monthlyWage * numberOfMonthworked;
//}



//double amountdouble = 1234;
//double monthdouble = 12;
//double bonusdouble = 1000;
////CalculateYearlyWage(amount, month);
//utilities.UsingNamedArguments();

Console.ReadLine();






//method with optional parameters

//int  AddNumbers(int a,int b,int c=100)
//{
//    int sum= a + b + c;
//    return sum;
//}

////calling method 
//int two=AddNumbers(20, 30);
//Console.WriteLine(two);

//int three=AddNumbers(20, 30,50);
//Console.WriteLine(two);

//int four = AddNumbers(b: 20, a:30, c:60);
//Console.WriteLine(four);






//Working With String
var mystring = string.Empty;

int l=mystring.Length;

string upper=mystring.ToUpper();
string  lower=mystring.ToLower();
bool b=mystring.Contains("Hello");
string s=mystring.Replace("a","b");
string sub = mystring.Substring(1, 3);













