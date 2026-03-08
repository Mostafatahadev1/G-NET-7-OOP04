namespace G_NET_7_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1 Question 1

            // Q1 : What is the difference between static binding and dynamic binding? When does each one happen?

            // Static Binding (Early Binding):
            // Happens at compile time. The compiler determines which method will be called
            // before the program runs.

            // Dynamic Binding (Late Binding):
            // Happens at runtime. The method call is resolved during program execution
            // depending on the actual object type.

            #endregion // 

            #region Question 2
            //Q2: What is the difference between method overloading and method overriding?

            // Method Overloading vs Method Overriding
            // ---------------------------------------
            // Method Overloading:
            // Means having multiple methods with the same name but different parameters
            // (different number or type of parameters). It happens in the same class
            // and is resolved at compile time.

            // Method Overriding:
            // Means redefining a method from a base class in a derived class using
            // the same method name and parameters. It requires inheritance and uses
            // virtual and override keywords, and it is resolved at runtime.
            #endregion

            #region Question 3

            //Q3 : What keywords are used for Method Overriding? What does each one mean ?

            // Keywords used for Method Overriding:

            // virtual:
            // Used in the base class to allow a method to be overridden in a derived class.

            // override:
            // Used in the derived class to provide a new implementation of a virtual method
            // from the base class.

            // base:
            // Used in the derived class to call the original method implementation
            // from the base class.
            #endregion

            // انا عملت اول تلات كوميت علشان حصل مشكله في ال first repo 

            #region Part 2 
           //Cinema cinema = new Cinema();
           //
           //cinema.Open();
           //
           //StandardTicket t1 = new StandardTicket("Inception", new Seat('A', 5));
           //t1.SetPrice(150);
           //
           //VIPTicket t2 = new VIPTicket("Avengers", true, 50);
           //t2.SetPrice(200);
           //
           //IMAXTicket t3 = new IMAXTicket("Dune", true);
           //t3.SetPrice(100, 1.8m);
           //
           //Console.WriteLine("\n========= SetPrice Test =========");
           //Console.WriteLine("Setting price directly: 150");
           //Console.WriteLine("Setting price with multiplier: 100 × 1.5 = 150\n");
           //
           //cinema.AddTicket(t1);
           //cinema.AddTicket(t2);
           //cinema.AddTicket(t3);
           //
           //Console.WriteLine("========= All Tickets =========");
           //cinema.PrintAllTickets();
           //
           //Cinema.ProcessTicket(t2);
           //
           //cinema.Close();
        
        #endregion

        }
    }
}
