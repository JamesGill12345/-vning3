using System.Data.Common;
using System.Runtime.CompilerServices;

int Hello32;
Hello32 = 0;
bool start = false;


// static void DoMath(int number)
// {

// }

// DoMath(5);

Console.WriteLine("skriv a för att starta");
string knapp;
knapp = Console.ReadLine();



if (knapp == "a")
{
    start = true;
}
else
{
    Console.WriteLine("Försök igen");
}

if (start = true)
{
    while (Hello32 < 32)
    {
        Console.WriteLine("Hello World!");
        Hello32 = Hello32 + 1;
    }

}



static void Multi()
{
    Console.WriteLine("Skriv ett tal");

    string numA = Console.ReadLine();
    int numA_int;
    int.TryParse(numA, out numA_int);

    Console.WriteLine("bra jobbat! skriv ett tal du vill multiplicera med talet du just skrev");

    string numB = Console.ReadLine();
    int numB_int;
    int.TryParse(numB, out numB_int);

    int resultat = numA_int * numB_int;

    Console.WriteLine($"ditt resultat blev {resultat}");

}








// (A*B)/2
// static int RightAreaTriangle()
// {
//     string TriA;

//     Console.WriteLine("För att räkna ut arean behöver jag ena sidans längd");

//     TriA = Console.ReadLine();

//     int TriA_int;
//     int.TryParse(TriA, out TriA_int);

//     string TriB;

//     Console.WriteLine("Bra jobbat nu kan du testa att lägga till ett nytt tal");
//     TriB = Console.ReadLine();

//     int TriB_int;
//     int.TryParse(TriB, out TriB_int);

//     int StegA = TriA_int * TriB_int;
//     int area = StegA / 2;
// }


static int GetNumberInput()
{
    double num = 0;
    fel:
    Console.WriteLine("Skriv tre tal");
    string DataA_string = Console.ReadLine();
    string DataB_string = Console.ReadLine();
    string DataC_string = Console.ReadLine();

    int DataA_int;
    int.TryParse(DataA_string, out DataA_int);

    int DataB_int;
    int.TryParse(DataB_string, out DataB_int);

    int DataC_int;
    int.TryParse(DataC_string, out DataC_int);
    if (DataA_int < 0 || DataB_int < 0|| DataC_int <0 )
    {
        goto fel;
    }
    else if (DataA_int != num || DataB_int != num|| DataC_int != num )
    {
        goto fel;
    }

    return DataA_int;
    return DataB_int;
    return DataC_int;
}

static double RightAreaTriangle()
{
    int DataA_int =  GetNumberInput();
    int DataB_int =  GetNumberInput();
    int DataC_int =  GetNumberInput();

   double Triarea = DataA_int * DataB_int / 2;

    return Triarea;
}



double a = Circlearea(3);


static double Circlearea(double r)
{
    Double pi = 3.14;
    Double Circarea;

    Circarea = pi * r * r;

    return Circarea;
}

static int GetChoice()
{
    Val:
    string string1 = Console.ReadLine();
    string string2 = Console.ReadLine();
    string string3 = Console.ReadLine();

    Console.WriteLine($"{string1} är första talet. {string2} är andra talet och {string3} är tredje talet välj ett tal genom att skriva det");

    string stringchoice = Console.ReadLine();
    if (stringchoice == string1 ||stringchoice == string2 || stringchoice == string3 )
    {
        Console.WriteLine($"ditt tal var {stringchoice}");
    }
    else
    {
        goto Val;
    }
    int numberint;

    int.TryParse (stringchoice, out numberint);

    return numberint;
}


Console.ReadLine();