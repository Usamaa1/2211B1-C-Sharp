// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine("Dusr\0a Text");

int num = 12;
num = 45;
Console.WriteLine(num);

string alpha = "Usama";
alpha = "sdfsad";
Console.WriteLine(alpha);

double p = 2.3;
Console.WriteLine(p);

var a = "dfdfsad";
a = "sadf";
Console.WriteLine(a);

const double pi = 3.14;
//pi = 2.2;
Console.WriteLine(pi);
*/


/*var name = "Usama";

Console.WriteLine("Hello "+ name + ", how are you");

Console.WriteLine($"Hello {name}, how are you");*/

/*int num = 12;

string str = "45";

string c = "a";

string boo = "true";

string doub = "2.3";*/

//var convert = num.ToString();
//var convert = Convert.ToInt16(str);
//var convert = Convert.ToBoolean(boo);
//var convert = Convert.ToDouble(doub);
//var convert = Convert.ToChar(c);

//Console.WriteLine(convert);
//Console.WriteLine(convert.GetType());



/*
int a = 23;
int b = 45;

Console.WriteLine($"The result of addition: {a + b}");
Console.WriteLine($"The result of subtract: {a - b}");
Console.WriteLine($"The result of multiply: {a * b}");
Console.WriteLine($"The result of divide: {a / b}");
Console.WriteLine($"The result of modulus: {a % b}");*/



//int a = 25;
//double a = 2.333;

//Console.WriteLine(Math.Pow(a,3));
//Console.WriteLine(a);
//Console.WriteLine(Math.Abs(a));
//Console.WriteLine(Math.Sqrt(a));
//Console.WriteLine(Math.Ceiling(a));
//Console.WriteLine(Math.Floor(a));
//Console.WriteLine(Math.Round(a));


//Console.WriteLine(Math.Min(12,34));

//Console.WriteLine(Math.Max(12,34));


//Random rand = new Random();

//Console.WriteLine(rand.Next(1,11));
//Console.WriteLine(rand.NextDouble());

/*string str = "This is String";

Console.WriteLine(str);
Console.WriteLine(str.ToUpper());
Console.WriteLine(str.ToLower());
Console.WriteLine(str.Length);
Console.WriteLine(str.Insert(1,"gfsdf"));
Console.WriteLine(str.Replace("is","gp"));
Console.WriteLine(str.Substring(5,2));*/









/*int age = 19;

if (age > 18)
{
    Console.WriteLine("You are above 18");
}
else if (age == 18)
{
    Console.WriteLine("Your age is 18");
}
else 
{
    Console.WriteLine("You are below 18");
}*/


//for(int i =0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//int j = 0;
//while (j <= 10)
//{
//    Console.WriteLine(j);
//    j++;
//}

/*int a = 0;
do
{
    Console.WriteLine(a);
    a++;
}
while (a == 10);*/


//string userInput;
/*
do
{
    Console.WriteLine("Enter your First Name");
    userInput = Console.ReadLine();
}
while (userInput == "");

Console.WriteLine($"Wellcome! {userInput}");*/



//int[] arr = { 1, 3, 4, 5, 6, 6 };
//int[] arr = new int[10];
//string[] strArr = { "Arif", "Zahid" };
//string[] strArry = new string[10];

/*int[] nums = new int[2];
nums[0] = 22;
nums[1] = 33;


for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

foreach (var item in nums)
{
    Console.WriteLine(item);
}
*/



/*   MULTIDIMENSIONAL ARRAY    */

/*int[,] nums = new int[3, 2];

nums[0, 0] = 10;
nums[0, 1] = 20;

nums[1, 0] = 40;
nums[1, 1] = 50;

nums[2, 0] = 70;
nums[2, 1] = 80;*/

//int[,] nums = { {10, 20}, {40, 50}, {70, 80} };

/*foreach(int item in nums)
{
    Console.WriteLine(item);
}*/


//for(int i = 0; i < nums.GetLength(0); i++)
//{
//    for(int j=0; j < nums.GetLength(1); j++)
//    {
//        Console.WriteLine(nums[i,j]);
//    }
//}

/* JAGGED ARRAY */

int[][] nums =
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5,},
    new int[] { 6, 7, 8, 9, 0 },
};

foreach(var item in nums)
{
    foreach(var n in item)
    {
        Console.WriteLine(n);
    }
}














Console.ReadKey();