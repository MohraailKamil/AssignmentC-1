using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //int a = 20, b = 5;
        // Console.WriteLine(a + b);
        // Console.WriteLine(a - b);
        // Console.WriteLine(a * b);
        // Console.WriteLine(a / b);
        //--------------------------------------
        //int x = 10, y = 20;
        //Console.WriteLine(x == y ? "Equal" : "Not Equal");
        //--------------------------------------
        //int age = 20, salary = 6000;
        //Console.WriteLine(age > 18 && salary > 5000 ? "True" : "False");
        //----------------------------------------
        //int x = 5;
        //int y = 3;
        //int z = x;
        //Console.WriteLine(z);
        //x += y;
        //Console.WriteLine(x);

        //---------------------------------------------
        //int x = 4;
        //int y = 5;
        //x = y;
        //x++;
        //y--;
        //Console.WriteLine(x);
        //Console.WriteLine(y);

        //---------------------------------------------

        //int num = 4;
        //Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        //------------------------------------------------------
        //string name = null;
        //string displayName = name ?? "Mohra";
        //Console.WriteLine(displayName);

        //string m = null;
        //m ??= "Malak";
        //Console.WriteLine(m);
        //-----------------------------------------------------------

        //string name = "Mahi";
        //int degree = 90;
        //Console.WriteLine("Name: " + name + " degree: " + degree);
        //-----------------------------------------------------------
        //DateTime today = DateTime.Today;
        //Console.WriteLine($"Today : {today: dd/MM/yyyy}");
        //----------------------------------------------------------
        //string s1 = "Hello";
        //string s2 = s1.Replace("Hello", "welcome");
        //Console.WriteLine(s2);
        //------------------------------------------------------------
        //StringBuilder sb = new StringBuilder("hello");
        //sb.Append(" world");
        //sb.Insert(6 , "c#");
        //sb.Remove(6 , 2);
        //Console.WriteLine(sb);
        //-------------------------------------------------------
        //int grade = 40;
        //Console.WriteLine(grade >= 50 ? "Pass" : "Fail");
        //----------------------------------------------------------
        //int n1 = 2;
        //switch (n1)
        //{
        //    case 1: Console.WriteLine("One"); break;
        //    case 2: Console.WriteLine("Two"); break;
        //    case 3: Console.WriteLine("Three"); break;
        //}
        //-----------------------------------------------------------------
        //int n2 = 3;
        //string result = n2 switch { 1 => "One", 2 => "Two", 3 => "Three", _ => "Other" };
        //Console.WriteLine(result);
        //---------------------------------------------------------
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //----------------------------------------------------------
        //string[] names = { "Mohra", "Malak", "Mahi", "Mai", "Koki" };
        //foreach (var name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //------------------------------------------------------------
        //int sum = 0;
        //int number = -1; 
        //while (number != 0)
        //{
        //    Console.Write("Enter a number (0 to stop): ");
        //    number = int.Parse(Console.ReadLine()); 
        //    sum += number; 
        //}
        //Console.WriteLine("Total sum = " + sum);
        //------------------------------------------------------------
        //string pass;
        //do
        //{
        //    pass = Console.ReadLine();
        //} while (pass != "1234");
        //Console.WriteLine("hello user");
        //----------------------------------------------------------
        //int[,] arr = new int[3, 3];
        //int num = 1;
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        arr[i, j] = num++;
        //        Console.WriteLine(arr[i,j]  + " ");
        //    }
        //    Console.WriteLine();
        //----------------------------------------------------------------
        //int[] arr = { 1, 2, 5, 9 };
        //int[] arr1 = arr;//shallow copy , same reference
        //arr[0] = 100;
        //Console.WriteLine(arr1[0]);

        //int[] arr = { 11, 2, 5, 9 };
        //int[] deep = (int[])arr.Clone();
        //arr[0] = 100;//deep copy , different reference
        //Console.WriteLine(deep[0]);
        Console.WriteLine("hello");

    }
}
    
