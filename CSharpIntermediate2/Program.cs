#region
//First version of getter and setters!!

//namespace CSharpIntermediate2
//{
//    class Person
//    {
//        private string _name;
//        public string GetName() { return _name; }
//        public void SetName(string name) { _name = name; }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var person = new Person();

//            person.SetName("Nelson");
//            Console.WriteLine(person.GetName());

//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region

//Second version of getter and setters!!
//namespace CSharpIntermediate2
//{
//    class Person
//    {
//        private string _name;
//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region

// Third version of getter and setters!!

//namespace CSharpIntermediate2
//{
//    class Person
//    {
//        private string _name;
//        public string Name { get; set; }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region

// Usefullness of inheritence: Call a list of an inherited class as a list

namespace CSharpIntermediate2
{
    class Person
    {
        private string _name;
        public string Name { get; set; }

    }
    class Employee : Person
    {

    }
    class Janitor : Person
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        static void PrintPeople(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine("Name: {0}", person.Name);
            }
        }
    }
}

#endregion