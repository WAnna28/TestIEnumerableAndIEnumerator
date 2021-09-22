using System;
using System.Collections;
using TestIEnumerableAndIEnumerator.Models;

namespace TestIEnumerableAndIEnumerator
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////
    // Any type supporting a method named GetEnumerator() can be evaluated by the foreach construct. //
    ///////////////////////////////////////////////////////////////////////////////////////////////////

    //public interface IEnumerable
    //{
    //    IEnumerator GetEnumerator();
    //}

    //public interface IEnumerator
    //{
    //    bool MoveNext(); // Advance the internal position of the cursor.
    //    object Current { get; } // Get the current item (read-only property).
    //    void Reset(); // Reset the cursor before the first member.
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            
            foreach (Employee e in office)
            {
                Console.WriteLine($"Name is{e.Name}\n EmployeeID is {e.EmployeeID}\n Salary is: {e.Salary}\n");
            }

            TestFunction(office);

            Console.ReadLine();
        }

        static void TestFunction(IEnumerable h)
        {

        }
    }
}
