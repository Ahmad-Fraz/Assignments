using System;
using static System.Console;

namespace Assignment_7

{
    public class Person1
    {
        public int age;
    }
    // Enums
    public enum ShippingMethod
    {
        DarazDilivery = 3,
        AliExpress,
        WishDelivery
    }
    // Assignment 7 - Examples of Non - Primitive types

    //  1===>>> Classes
    public class Person         // Declaring a class for person
    {
        public string name = "Ahmad";

        public void Introduce()
        {
            WriteLine("My name is " + name);
        }
    }

    public class Add            // Declaring a class for adding two numbers + Static methods in classes
    {


        public static int plus(int x, int y)
        {
            return x + y;
        }

    }


    // ------------------- Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // -------------- Calling Person Class
            var P1 = new Person();
            P1.Introduce();

            // ------------------- Calling plus function in Add class
            var result = Add.plus(12, 34);
            WriteLine(result);

            //  2 ===>>>   Arrays

            // integer array
            int[] numbers = new int[3];
            numbers[0] = 12;
            numbers[1] = 22;
            numbers[2] = 34;

            foreach (int i in numbers)
            {
                WriteLine("The values of array are {0}", i);
            }

            // bool array
            var flags = new bool[3] { true, false, true };
            foreach (bool i in flags)
            {
                WriteLine(i);
            }

            // String array
            string[] names = new string[3] { "Ahmad", "Adanan", "Arshad" };
            foreach (string i in names)
            {
                WriteLine("The name are {0}", i);
            }

            var number = new int[3] { 1, 2, 3 };
            string list = string.Join("+", number);
            WriteLine(list);

            // choosing only a char from string
            string name = "Ahmad";
            char firstchar = name[0];
            WriteLine(firstchar);
            // Formating Strings
            var firstName = "Ahmad";
            var secondName = "Faraz";
            var myFullName = string.Format("My full name is {0} {1}", firstName, secondName);
            WriteLine(myFullName);

            var namees = new string[3] { "Arslan", "Noman", "Hamza" };
            var FormatedText = string.Join(",", namees);
            WriteLine(FormatedText);

            // Verbital Strings
            WriteLine("C:\\Users\\Faraz\\Desktop\\Assignment 7\\Assignment 7.csproj");       //Escape Sequences
            WriteLine(@"C:\Users\Faraz\Desktop\Assignment 7\Assignment 7.csproj");      //Verbital String

            // calling enum
            var method = ShippingMethod.WishDelivery;
            WriteLine((int)method);

            var methodID = 5;
            WriteLine((ShippingMethod)methodID);

            //  array pass by reference
            var array1 = new int[3] { 0, 1, 2 };
            var array2 = array1;
            array2[0] = 3;

            WriteLine(array1[0]);
            WriteLine(array2[0]);

            // 
            var num = 1;
            Increment(num);
            WriteLine(num);

            var pperson = new Person1() { age = 20 };
            MakeOld(pperson);
            WriteLine(pperson.age);


        }
        // Static Methods
        public static void MakeOld(Person1 agee)
        {
            agee.age += 10;
        }

        public static void Increment(int number3)
        {
            number3 += 10;
        }
    }
}
