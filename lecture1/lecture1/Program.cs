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

/*int[][] nums =
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
}*/



/*int[] nums = new int[5];

nums[0] = 1;
nums[1] = 2;
nums[2] = 3;
nums[3] = 4;
nums[4] = 5;*/
//nums[5] = 6;
//nums[6] = 7;
//nums[7] = 8;

/*foreach (int i in nums)
{
    Console.WriteLine(i);
}*/


//LIST Starts from here

/*
List<int> nums = new();


nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(4);
nums.Add(5);
nums.Add(6);
nums.Add(7);
nums.Add(8);
nums.Add(9);
nums.Add(10);
nums.Add(7);

nums.Clear();
nums.Remove(8);
Console.WriteLine(nums.Contains(8));
Console.WriteLine("Count: "+nums.Count());
Console.WriteLine($"index of: {nums.IndexOf(7)}");
Console.WriteLine($"Last index of: {nums.LastIndexOf(7)}");

nums.Reverse();
nums.Sort();



foreach (int i in nums)
{
    Console.WriteLine(i);
}*/

//LIST Ends here

//Classes Starts from here





/*Car alto = new();

alto.name = "Alto VXR";
alto.model = 2023;
alto.brand = "Suzuki";
alto.airBags = "Yes";
alto.automatic = "Yes";*/


//Car alto = new()
//{
//    name = "Alto VXR",
//    model = 2014,
//    brand = "Suzuki",
//    airBags = "No",
//    automatic = "No"
//};

//Car alto = new("Alto VXR","Suzuki","No","Yes");
//Car mehran = new Car("Mehran special Edition", "Suzuki",2020, "No","Yes");
//Car city = new("City Aspire", "Honda", 2023, "Yes", "Yes");

////Console.WriteLine($" Car Name: {alto.name}\n Model: {alto.model}\n Brand: {alto.brand}\n Airbags: {alto.airBags}\n Automatic: {alto.automatic}");
////Console.WriteLine($" Car Name: {mehran.name}\n Model: {mehran.model}\n Brand: {mehran.brand}\n Airbags: {mehran.airBags}\n Automatic: {mehran.automatic}");

//Console.WriteLine(city.printCar());
////Console.WriteLine(alto.printCar());
////Console.WriteLine(mehran.printCar());

//Console.WriteLine($"Price: ${city.carPrice(450) + 50}");
////city.carPrice(450);

//Console.ReadKey();

//class Car
//{
//    public string name;
//    public string brand;
//    public int model;
//    public string airBags;
//    public string automatic;

//    public Car(string carName, string carBrand, int carModel, string carAirBags, string carAutomatic)
//    {
//        this.name = carName;
//        this.brand = carBrand;
//        this.model = carModel;
//        this.airBags = carAirBags;
//        this.automatic = carAutomatic;
//    }

//    public Car(string carName, string carBrand, string carAirBags, string carAutomatic)
//    {
//        this.name = carName;
//        this.brand = carBrand;
//        this.airBags = carAirBags;
//        this.automatic = carAutomatic;
//    }

//    //public void printCar()
//    //{
//    //    Console.WriteLine($" Car Name: {this.name}\n Model: {this.model}\n Brand: {this.brand}\n Airbags: {this.airBags}\n Automatic: {this.automatic}");
//    //}
//    public string printCar()
//    {
//       return $" Car Name: {this.name}\n Model: {this.model}\n Brand: {this.brand}\n Airbags: {this.airBags}\n Automatic: {this.automatic}";
//    }

//    public int carPrice(int price)
//    {
//        return price + 100;
//    }

//    //public void carPrice(int price)
//    //{
//    //    Console.WriteLine(price + 100);
//    //}



//}


//Classes Ends here


//CLASSES


/*
 -POLYMORPHISM
 -ENCAPSULATION
 -ABSTRACTION
 -INHERITANCE
*/

//INHERITANCE
//grandfather -> father -> child

//UbisoftGame farCry = new()
//{
//    gameName = "Far Cry 6",
//    gameVersion = 6.5,
//    companyName = "Ubisoft",
//    players = 4,

//};
//farCry.nextGameLaunchText("On next thursday of Jan 2025");

//Console.WriteLine(farCry.printInfo());

//Console.WriteLine(farCry.gameName);



//RockstarGame GTA = new()
//{
//    gameName = "GTA 5",
//    gameVersion = 5.3,
//    companyName = "Rockstar",
//    players = 1
//};
//Console.WriteLine(GTA.printInfo());

//Game a = new()
//{
//    gameName = "A",
//    gameVersion = 1,
//    companyName = "AAA",
//    players = 2,
//};

//Console.WriteLine(a.printInfo());



//class Game
//{
//    public string gameName;
//    public double gameVersion;
//    public int players;
//    public string companyName;
//    //private string nextGameLaunch = "";
//    protected string nextGameLaunch;

//    //Polymorphism ---> many forms
//    public virtual string printInfo()
//    {
//        return "Here will be the text message from objects properties";
//    }
//}


//class UbisoftGame : Game
//{
//   public void nextGameLaunchText(string arg)
//    {
//        this.nextGameLaunch = arg;
//    }
//    //Polymorphism ---> many forms
//    public override string printInfo()
//    {
//        return $"Game Name: {this.gameName} \nCompany Name: {this.companyName} \nGame Version: {this.gameVersion} \nPlayers: {this.players} \nNext Game Launch: {this.nextGameLaunch} \n\n";
//    }
//}

//class RockstarGame : UbisoftGame
//{
//    //Polymorphism ---> many forms
//    public override string printInfo()
//    {
//        return $"Game Name: {this.gameName} \nCompany Name: {this.companyName} \nGame Version: {this.gameVersion} \nPlayers: {this.players} \nNext Game Launch: {this.nextGameLaunch} \n\n ---- The Information Ends here";
//    }
//}




// ENCAPSULATION


//Bank asfar = new()
//{
//    accountHolder = "Asfar Amjad",
//    accountNumber = 18983249839
//};


//asfar.setAccountBalance(56000);
//asfar.passCodeReset(5678);
//asfar.printAccount();

//asfar.passCodeReset(4522);

//asfar.printAccount();


//Console.WriteLine("");
//Console.WriteLine(asfar.accountHolder);
//Console.WriteLine(asfar.passCode);



//class Bank
//{
//    public string accountHolder;
//    public double accountNumber;
//    private int passCode;
//    private int accountBalance;


//    public void passCodeReset(int newPassCode)
//    {
//        this.passCode = newPassCode;
//    }

//    public void seeAccountBalance()
//    {
//        Console.WriteLine(this.accountBalance);
//    }
//    public void setAccountBalance(int newBalance)
//    {
//        this.accountBalance = newBalance;
//    }

//    public void printAccount()
//    {
//        Console.WriteLine($"Account Holder: {this.accountHolder}");
//        Console.WriteLine($"Account Number: {this.accountNumber}");
//        Console.WriteLine($"Account Balance: {this.accountBalance}");
//        Console.WriteLine($"Passcode: {this.passCode}");
//    }


//}


//ABSTRACTION



AlfalahBank Haris = new()
{
    accountHolder = "Haris Naseer",
    accountNumber = 342334233333,
};

Haris.passCodeReset(2343);

Haris.printAccount();



abstract class Bank
{
    public string accountHolder;
    public double accountNumber;
    protected int passCode;
    protected int accountBalance;
    public virtual void printAccount() { }
    public virtual void seeAccountBalance(){ }
    public virtual void passCodeReset(int newPassCode) { }
    public virtual void setAccountBalance(int newBalance){ }

}


class AlfalahBank : Bank
{
    public override void printAccount() 
    {
        Console.WriteLine($"Account Holder: {this.accountHolder}");
        Console.WriteLine($"Account Number: {this.accountNumber}");
        Console.WriteLine($"Account Balance: {this.accountBalance}");
        Console.WriteLine($"Passcode: {this.passCode}");
    }
    public override void seeAccountBalance() 
    {
        Console.WriteLine(this.accountBalance);
    }
    public override void passCodeReset(int newPassCode) 
    {
        this.passCode = newPassCode;
    }


}


























