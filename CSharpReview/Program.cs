using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8,0,0 };
            score[8] = 9;
            score[9] = 10;

            foreach (var i in score)
            {
                Console.WriteLine(i);
            }

            int x;

            x = score[0];

            Console.WriteLine(x);

            string name = "Chris";
            int y;

            y = name.Length;

            Console.WriteLine(name + y);

            //reverse strings
            char[] cname = name.ToCharArray();
            Array.Reverse(cname);
            Console.WriteLine(cname);

            string str = "This is a string";
            Console.WriteLine(str);
            char[] cstr = str.ToCharArray();
            Array.Reverse(cstr);
            Console.WriteLine(cstr);

        }
    }
}
//3 tenets of oop?
//polymorphism, inheritance, encapsulation (PIE)

//ternary operator?
//coditional operator (?:), evaluates a boolean expression
// var x = (condition) ? (true "consequence") : (false "alternative")
//returns one of two values depending on the value of a boolean expression

//what the foreach statement does?
//executes a statement or a block of statements "for each" element in an instance of the type.
//"iteration through a collection"
// foreach (var item in collection)

//know how to index into a array?
//use the name of the array and element index number
// x = score[0];

//what can be the contents of an interface?
//an interface defines a contract
//A class or struct that implements an interface must adhere to its contract
//"the class must implement all methods in the interface"
//an interface may inherit from multiple base interfaces
//name should start with "I"
//interfaces dont provide implementation details
//"methods (without bodies)"
//define data types, and names (they define members, but not the implementation)
//used to create consistency 
//interfaces can be used to create polymorphic behavoir

//when you have a generic collection class, what type of data can be entered into it?
//data of the same type (Data deriving or implementing the same type)

//what method must exist in any c# executable program?
//the main method

//how to determine the length of a string?
// y = name.Length;

//what data is needed for a dictionary?
//type of the keys, and type of the values
//key/values

//difference between a nullable int and a int?
//nullable ints can be null, and the value type int cannot be
