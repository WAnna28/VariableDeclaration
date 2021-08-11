using System;

namespace VariableDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Understanding Variable Declaration and Initialization! ***********\n");

            // Local variables are declared and initialized as follows:
            // dataType varName = initialValue;

            int testInt = 0;

            // You can also declare and assign on two lines.
            double testDouble;
            testDouble = 1982.7;

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Single data type to declare a float.
            System.Single singleTest = 3.14F;

            // The default Literal (New 7.1)
            // The default literal assigns a variable the default value for its data type.
            double testDoubleDefault = default;
            float testFloatDefault = default;
            char testCharDefault = default;
            string testStringDefault = default;

            // Using Intrinsic Data Types and the new Operator (Updated 9.0)
            double dNewLong = new double(); // Set to 0.
            DateTime dtNewLong = new DateTime(); // Set to 1/1/0001 12:00:00 AM
            // C# 9.0 adds a shortcut for creating variable instances.
            // This shortcut is simply using the keyword new() without the data type.
            double dNewShort = new(); // Set to 0.
            DateTime dtNewShort = new(2020, 5, 5); // Set to 1/1/0001 12:00:00 AM

            int? k = null;
            Console.WriteLine(k);

            string p = "mklk;k;k;";
            Console.WriteLine(p[p.Length + 10]);

             Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}",
                testInt, testDouble, b1, b2, b3, singleTest, testDoubleDefault, testFloatDefault, testCharDefault, testStringDefault, dNewLong, dtNewLong, dNewShort, dtNewShort);

            Console.ReadLine();
        }
    }
}
