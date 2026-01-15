//// static is a modifier that makes a member belong to a type, rather than an "instance" of a type
//// we can even make entire classes static.

//// note that we cannot make an instance of "MyStaticClass" because it is marked static
//// MyStaticClass myStaticClass = new MyStaticClass(); // this will not work!

//// static classes cannot have instance members, so anything inside of a static class must also be static
//MyStaticClass.MyStaticMethod();

//MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
//MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();

//Console.WriteLine("Before mutating properties on MyNonStaticClass...");
//myNonStaticClass1.MyInstanceMethod();
//myNonStaticClass2.MyInstanceMethod();
//MyNonStaticClass.MyStaticMethod();

//// let's mutate these things and see what happens!
//myNonStaticClass1.MyInstanceProperty = "Dev";
//myNonStaticClass2.MyInstanceProperty = "Leader";
//MyNonStaticClass.MyStaticProperty = "Zohidbek Abduqodir";

//Console.WriteLine("After mutating properties on MyNonStaticClass...");
//myNonStaticClass1.MyInstanceMethod();
//myNonStaticClass2.MyInstanceMethod();
//MyNonStaticClass.MyStaticMethod();

//// on non-static classes, we *can* add static members
//class MyNonStaticClass
//{
//    public string MyInstanceProperty { get; set; } = "Zohidbek";

//    public static string MyStaticProperty { get; set; } = "Abduqodir";

//    public static void MyStaticMethod()
//    {
//        Console.WriteLine($"The static property value is: {MyStaticProperty}");

//        // this will not work because MyInstanceProperty is not static!
//        // Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
//    }

//    public void MyInstanceMethod()
//    {
//        Console.WriteLine($"The static property value is: {MyStaticProperty}");
//        Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
//    }
//}

//static class MyStaticClass
//{
//    public static void MyStaticMethod()
//    {
//        Console.WriteLine("I am a static method!");
//    }
//}