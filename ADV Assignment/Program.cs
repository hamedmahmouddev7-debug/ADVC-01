using ADV_Assignment;

namespace ADV01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // What is a generic class? Why use generics? 

            //Generics allow you to write one reusable class or method that works with different data types safely.
            #endregion

            #region Question02
            // Write a generic class Container<T> with Add and Get methods

            /*
             Container<int> container = new Container<int>();

                  container.Add(10);

                   Console.WriteLine(container.Get());

            */
            #endregion

            #region Question03
            //What are multiple type parameters? Write Pair<TKey, TValue>. 
            /*
             * Pair<int, string> pair = new Pair<int, string>(1, "Ahmed");

                 Console.WriteLine(pair.Key);
                 Console.WriteLine(pair.Value);
             */
            #endregion

            #region Question04
            //  What is a generic method? Write Swap<T> method. 
            /* A generic method is a method that uses a type parameter such as T, allowing the same method to work with different data types.

             static void Swap<T>(ref T a, ref T b)
               {
                  T temp = a;
                  a = b;
                  b = temp;
               }
                  int x = 10;
                  int y = 20;
                  
                  Swap(ref x, ref y);
                  
                  Console.WriteLine(x);
                  Console.WriteLine(y);
             */
            #endregion

            #region Question05
            // Write a generic method FindMax<T> that finds maximum value 

            /*
             * static T FindMax<T>(T a, T b) where T : IComparable<T>
               {
                   if (a.CompareTo(b) > 0)
                       return a;
                   else
                       return b;
               }
              int max = FindMax(10, 20);

              Console.WriteLine(max);
              */

            #endregion

            #region Question06
            //  What is a generic interface? Write IRepository<T>.  

            /*A generic interface is an interface that uses a type parameter such as T, allowing it to work with different data types.
             * 
             IRepository<string> repository;
             */
            #endregion

            #region Question07
            // What is the 'struct' constraint? Write an example. 
            /* The struct constraint means that the generic type T must be a value type.
             * Storage<int> s = new Storage<int>();
             s.Value = 10;

            Console.WriteLine(s.Value);
             */
            #endregion

            #region Question08
            // What is the 'class' constraint? Write an example. 

            /*The class constraint means that the generic type T must be a reference type.
             
             Storage<string> s = new Storage<string>();
s            .Value = "Hello";

              Console.WriteLine(s.Value);
             
             */
            #endregion

            #region Question09
            //What is the 'new()' constraint? Write an example. 
            //The new() constraint means that the generic type T must have a public parameterless constructor.
            /*Factory<Student> factory = new Factory<Student>();

             Student student = factory.Create();
            */
            #endregion

            #region Question10
            // What is the interface constraint? Write an example.
            //An interface constraint means that the generic type T must implement a specific interface.

            #endregion

            #region Question11
            //What is the base class constraint? Write an example.
            // A base class constraint means that the generic type T must inherit from a specific base class.
            //  It is written using where T: BaseClass.

            /*
              AnimalContainer<Dog> container = new AnimalContainer<Dog>();
              container.MakeEat(new Dog());
             * */
            #endregion

            #region Question12
            //  How do you apply multiple constraints? Write an example.  

            /*Multiple constraints mean applying more than one constraint to the same generic type T.
              You can combine a base class, interface, and new() constraint.


             * */

            #endregion

            #region Question13
            //What does the 'default' keyword do in generics?
            /*
               The default keyword returns the default value of a generic type T.
             * */

            #endregion

            #region Question14
            //Write a SafeList<T> that returns default when the index is invalid. 
            /*
             * SafeList<int> numbers = new SafeList<int>();

               numbers.Add(10);
               numbers.Add(20);
               
               Console.WriteLine(numbers.Get(0));  // 10
               Console.WriteLine(numbers.Get(5));  // 0
            */
            #endregion

            #region Question15
            // What is covariance? Explain the 'out' keyword. 
            /*
             * Covariance allows you to use a more derived type where a base type is expected, mainly with generic interfaces and delegates.
             */
            #endregion

            #region Question16
            // What is contravariance? Explain the 'in' keyword. 
            /*
             *Contravariance allows you to use a base type where a derived type is expected, mainly with generic interfaces and delegates.
             */
            #endregion

            #region Question17
            // What is the difference between covariance and contravariance?
            /*
             * Covariance (out) → I<Derived> can be assigned to I<Base>.
             * Contravariance (in) → I<Base> can be assigned to I<Derived>.
            */
            #endregion

            #region Question18
            // How do static members work in generic types? 
            /*
             * In a generic class, each different type parameter has its own separate copy of static members.
             */
            #endregion
        }
    }
}