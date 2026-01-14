//// we can "implicitly" cast between types that are compatible
//// for example, we can convert an int to a double
//int myInt = 5;
//double myDouble = myInt;
//Console.WriteLine("Implicit Cast");
//Console.WriteLine($"myInt={myInt}");
//Console.WriteLine($"myDouble={myDouble}");

//// we can also "explicitly" cast between types that are compatible
//// for example, we can convert a double to an int
//myDouble = 5.5;
//myInt = (int)myDouble;
//Console.WriteLine("Explicit Cast");
//Console.WriteLine($"myInt={myInt}");
//Console.WriteLine($"myDouble={myDouble}");

//// we cannot "cast" between types that are not compatible
//// for example, we cast convert a string to an int
//string myString = "5";
//// myInt = (int)myString; // This line would cause a compile-time error

//// we can also convert between types that are not compatible
//// for example, we can convert a string to numbers
//myInt = int.Parse(myString);
//Console.WriteLine("Parse");
//Console.WriteLine($"myString={myString}");
//Console.WriteLine($"myInt={myInt}");

//myString = "5.5";
//myDouble = double.Parse(myString);
//Console.WriteLine($"myString={myString}");
//Console.WriteLine($"myDouble={myDouble}");