//// a field is a variable that is declared directly in a class.

//// here is how we declare a field in a class

//class Person
//{
//    private string _name;

//    public void SomeMe()
//    {
//        this._name = "John";
//    }
//}

//// we can give a field a value when we declare it
//class Person2
//{
//    private string _name = "John";
//}

//// A property is a member that provides a flexible mechanism to
//// read, write, or compute the value of a private field.
//class Person4
//{
//    private string _name = "John";

//    public string Name
//    {
//        get
//        {
//            return _name;
//        }
//    }

//    public string Name2 => _name; // => is get only

//    public string Name3 { get; } = "John";

//    public string MutableName
//    {
//        get { return _name; }
//        set { _name = value; }
//    }
//}