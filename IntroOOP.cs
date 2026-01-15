//// object oriented programming is a programming paradigm
//// that uses objects and classes in programming
//// we can structure a program by bundling related
//// properties and behaviors into individual objects
//// this means that for the first time we start to think
//// about our programs less like just series of steps
//// and more like a collection of things that interact!

//// we can create an object from a class by using the new keyword
//OurClass ourObject = new OurClass();

//// we can use the short-form method to create an object
//OurClass ourObject2 = new();

//// let's make a new instance!
//OurSecondClass ourSecondObject = new();
//ourSecondObject.ExampleMethod();

//int result = ourSecondObject.ExampleFunction();

//// where else have we seen classes and objects?
//// the Console class!
//Console.WriteLine("This is a method on the Console class!");

//// objects are "reference types" in C#
//// and up until now we've only been working with
//// "value types" like int double, and bool
//// ... except for our collections!

//OurClass object1 = new OurClass(); // new reference
//OurClass object2 = new OurClass(); // new reference
//OurClass object3 = object1; // same reference as object1!

//Console.WriteLine("object1 == object2:");
//Console.WriteLine(object1 == object2); // false
//Console.WriteLine("object1 == object3:");
//Console.WriteLine(object1 == object3); // true

//// collections are very much the same!
//List<int> myNumbers1 = new List<int> { 1, 2, 3 };
//List<int> myNumbers2 = new List<int> { 1, 2, 3 };

//Console.WriteLine("myNumbers1 == myNumbers2:");
//Console.WriteLine(myNumbers1 == myNumbers2); // false

//// in C# we can create a class by using the class keyword
//public class OurClass
//{

//}

//// remember the methods and functions we were creating?
//// we can now create methods and functions that are
//// associated with a class!
//public class OurSecondClass
//{
//    public void ExampleMethod()
//    {
//        Console.WriteLine("Hello from our method!");
//    }

//    public int ExampleFunction()
//    {
//        return 42;
//    }
//}