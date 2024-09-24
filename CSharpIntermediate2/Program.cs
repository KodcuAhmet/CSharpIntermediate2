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

//// Usefullness of inheritence: Call a list of an inherited class as a list

//namespace CSharpIntermediate2
//{
//    class Person
//    {
//        private string _name;
//        public string Name { get; set; }

//    }
//    class Employee : Person
//    {

//    }
//    class Janitor : Person
//    {

//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var people = new List<Person>();
//            people.Add(new Employee());
//            people.Add(new Janitor());

//            Console.ReadKey();
//        }
//        static void PrintPeople(List<Person> people)
//        {
//            foreach (var person in people)
//            {
//                Console.WriteLine("Name: {0}", person.Name);
//            }
//        }
//    }
//}

#endregion

#region

//// You can inherit only from one class in C#
//// What if we want a Car class to inherit both Purchasable and Movable classes?
//// We cannot in C# because C# is single inheritence language
//// The solution is interfaces
//// An interface cannot have implementation in it

//namespace CSharpIntermediate2
//{
//    abstract class Purchasable
//    {

//    }
//    abstract class Movable : Purchasable
//    {

//    }
//    abstract class Car : Movable
//    {
//        abstract public void Talk();
//        public void Drive()
//        {
//            Console.WriteLine("VROOOOOOM!");
//        }
//        public virtual void TurboBoost()
//        {
//            Console.WriteLine("Stuff and things!");
//        }
//    }
//    class Car1 : Car
//    {
//        public override void Talk()
//        {

//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var objects = new List<object>();
//            objects.Add(10);
//            objects.Add("Whoa");
//            objects.Add(new Car1());

//            foreach (var item in objects)
//            {
//                if (!(item is Purchasable))
//                    continue;

//                var purchasable = (Purchasable)item;
//                Console.WriteLine("Do you want to purchase: {0}", purchasable);
//            }

//            Console.ReadKey();
//        }
//    }
//}

#endregion


#region

// An interface cannot have implementation in it
// Unlike class inheritence, you can implement as many interfaces as you want

namespace CSharpIntermediate2
{
    interface IMovable
    {
        void Move();
    }
    interface IBuyable
    {
        decimal Price { get; }
        void Buy();
    }
    class Car : IMovable, IBuyable
    {
        public decimal Price { get; private set; }
        public Car(decimal price)
        {
            Price = price;
        }
        public void Buy()
        {
            Console.WriteLine("You bought a car for {0}", Price);
        }
        public void Move()
        {
            Console.WriteLine("VROOOOM!");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

#endregion