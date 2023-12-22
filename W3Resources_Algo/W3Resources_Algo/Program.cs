using System;
using System.Security.Cryptography.X509Certificates;

namespace W3Resources_Algo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solutions solutions = new Solutions();

            //Console.WriteLine (solutions.Sum(15, 35));


            //Console.WriteLine(solutions.Difference(51));

            //Console.WriteLine( solutions.Check(25, 30));

            //Console.WriteLine(solutions.Within(104));


            //Console.WriteLine(solutions.Concat("ifelse"));

            //Console.WriteLine(solutions.CharRemove("Python", 1));

            //Console.WriteLine(solutions.RemoveGivenChar("Python", 'z'));

            //Console.WriteLine(solutions.XchangeChar("abcd"));

            //Console.WriteLine(solutions.JoinStrings("Olisaeloka"));

            //try
            //{
            //    Console.WriteLine(solutions.ConcatLastChar("Tegidor"));                
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine(solutions.MultipleCheck(55));


            //Console.WriteLine(solutions.FirstThreeChar("AB CowBoy"));


            //Console.WriteLine(solutions.StartWith("CSharp Developer"));


            //Console.WriteLine(solutions.TempCheck(150, -30));


            //solutions.RangeGPT();


            //Console.WriteLine(solutions.Ranges(70, 30, 15));


            //Console.WriteLine(solutions.CheckRange(3, 40));


            //Console.WriteLine(solutions.FirstTwo("ytade"));


            //Console.WriteLine(solutions.ModifyString("Sytide"));


            Console.WriteLine(solutions.Largest(10, 20, 30));

        }


        

    }


    public class Solutions
    {
        //public int Sum(int x, int y)
        //{

        //    return 

        //    x == y ? (x + y) * 3 : x + y;
        //}


        //public int Difference(int n)
        //{
        //    return n > 51 ? (n - 51) * 3 : 51 - n;
        //}


        //public bool Check(int x, int y)
        //{
        //    if (x == 30 || y == 30) 
        //        return true;

        //    if (x + y == 30)
        //        return true;

        //    return false;
        //}


        //public bool Within(int s)
        //{

        //if (s >= 90 && s <= 99)
        //    return true;

        //if (s >= 101 && s <= 110)
        //    return true;

        //if (s >= 190 && s <=199)
        //    return true;
        //if (s >= 201 && s <= 210)
        //    return true;

        //return false;
        // }


        //public string Concat(string x)
        //{
        //    if (x.StartsWith("if"))

        //        return x;

        //    return "if " + x;
        //}


        //public string CharRemove(string y, int x)
        //{          
        //    if (x >= 0 && x < y.Length - 1)
        //    {
        //       y = y.Remove(x, 1);
        //    }

        //    return y;

        //    //Remove() of Strings takes in 2 parameters, first is the position from where to start removing,
        //    //second is how many characters from that position to  be removed.

        //}

        //public string RemoveGivenChar(string y, char x)
        //{
        //    int Position = y.IndexOf(x);

        //    if (Position >= 0)
        //    {
        //        string New = y.Remove(Position, 1);

        //        return New;
        //    }

        //    Console.WriteLine($"{x} does not exist in the string");
        //    return y;
        //}


        //public string XchangeChar(string input)
        //{
        //    if(input.Length <= 1)
        //    {
        //        Console.WriteLine("input string is too short");
        //    }

        //    Char[] myArray = input.ToCharArray();

        //    char first = myArray[0];
        //    myArray[0] = myArray[input.Length - 1];
        //    myArray[input.Length - 1] = first;


        //    return new string(myArray);


        //}


        //public string JoinStrings(string input)
        //{
        //    if (input.Length < 2)
        //    {
        //        Console.WriteLine("Input String is too short");
        //        return input;
        //    }



        //    Char[] chars = input.ToCharArray(); // Can be omitted because strings in C# are
        //                                        // also indexed as their equivalent CharArray.

        //    string takeOut = new string ( new char[] { chars[0], chars[1] } );

        //    string result = takeOut + takeOut + takeOut + takeOut;

        //    return result;          

        //}


        //public string ConcatLastChar(string input)
        //{
        //    if (input.Length < 1)
        //    {

        //        Console.WriteLine("Input a String for Concat Operations");
        //        return input;

        //    }


        //    Char[] chars = input.ToCharArray();
        //    char lastChar = chars[input.Length - 1];

        //    string result = lastChar + input + lastChar;

        //    return result;
        //}


        //public bool MultipleCheck(int num)
        //{
        //    if (num % 3 == 0 || num % 7 == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        //public string FirstThreeChar(string v)
        //{
        //    if (v.Length < 3)
        //    {
        //        return v + v + v;
        //    }
        //    else
        //    {
        //        Char[] myChars = v.ToCharArray();

        //        string needed = new string(new Char[] { myChars[0], myChars[1], myChars[2] });
        //        return needed + v + needed;
        //    } 
        //}


        //public bool StartWith(string input)
        //{
        //    if (string.IsNullOrWhiteSpace(input))
        //    {
        //        Console.WriteLine("In put a string to be verified");
        //        return false;
        //    }

        //    return input.StartsWith("C#");
        //}


        //public bool TempCheck(int a, int b)
        //{
        //    if (a < 0 && b > 120 || a > 120 && b < 0)
        //    {
        //        return true;
        //    }
        //        return false;

        //}

 
        //public void RangeGPT()
        //{
        //    // Sample Input
        //    int num1, num2;
        //    Console.Write("Enter the first integer: ");
        //    if (int.TryParse(Console.ReadLine(), out num1))
        //    {
        //        Console.Write("Enter the second integer: ");
        //        if (int.TryParse(Console.ReadLine(), out num2))
        //        {
        //            // Check if either of the integers is in the range 100..200
        //            bool result = IsInRange(num1) || IsInRange(num2);

        //            // Display the result
        //            Console.WriteLine(result);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input for the second integer.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input for the first integer.");
        //    }
        //}

        //// Function to check if a number is in the range 100..200 inclusive
        //static bool IsInRange(int number)
        //{
        //    return number >= 100 && number <= 200;
        //}
    


        //public bool RangeCheck(int a, int b)
        //{
        //    if (a >= 100 && a <= 200 || b >= 100 && b <= 200)
        //    {
        //        return true;
        //    }
        //    return false;

        //}


        //public bool Ranges(int c, int d, int q)
        //{
        //    if (c >= 20 && c <= 50 || d >= 20 && d <= 50 || q >= 20 && q <= 50)
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        //public bool CheckRange(int num1, int num2)
        //{

        //    bool inRange1 = num1 >= 20 && num1 <= 50;
        //    bool inRange2 = num2 >= 20 && num2 <= 50;

        //    return inRange1 != inRange2;
        //}


        //public string FirstTwo(string z)
        //{
        //    string initial = z.Substring(0, 2);

        //    if (initial == "yt")
        //    {
        //        return z.Remove(0, 2);
        //    }
        //    else
        //    {
        //        return z;
        //    }
        //}


        // Function to check if 'yt' appears at index 1 and modify the string accordingly
        //public string ModifyString(string input)
        //{
        //    if (input.Length >= 2 && input.Substring(1, 2) == "yt")
        //    {
        //        return input.Remove(1, 2);  
        //    }
        //    else
        //    {
        //        return input;
        //    }
        //}


        public int Largest(int a, int b, int c)
        {
             return Math.Max(Math.Max(a, b), c);

             
        }

    }

}