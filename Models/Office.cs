using System.Collections;

namespace TestIEnumerableAndIEnumerator.Models
{
    public class Office : IEnumerable
    {
        private Employee[] employees = new Employee[4];

        private Employee[] employees2 = new Employee[4];

        public Office()
        {
            employees[0] = new Employee("Poghos Poghosyan", "DKk775757", 100000);
            employees[1] = new Employee("Adam Smith", "DE5444757", 300000);
            employees[2] = new Employee("Jane Smith", "Dk773757", 500000);
            employees[3] = new Employee("Petros Petrosyan", "DV888977", 400000);

            employees2[0] = new Employee("2Poghos Poghosyan", "DKk775757", 100000);
            employees2[1] = new Employee("2Adam Smith", "DE5444757", 300000);
            employees2[2] = new Employee("2Jane Smith", "Dk773757", 500000);
            employees2[3] = new Employee("2Petros Petrosyan", "DV888977", 400000);
        }

        // Iterator method - version 1.
        public IEnumerator GetEnumerator() => employees.GetEnumerator();

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Employee е in employees)
        //    {
        //        yield return е;
        //    }

        //    foreach (Employee е in employees2)
        //    {
        //        yield return е;
        //    }
        //}

        // Iterator method - version 2.
        // The yield keyword is used to specify the value(or values) to be returned to the caller’s foreach construct.
        // When the yield return statement is reached, the current location in the container is stored,
        // and execution is restarted from this location the next time the iterator is called.
        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Employee е in employees)
        //    {
        //        yield return е;
        //    }
        //}

        // Iterator method - version 3.
        // Iterator methods are not required to use the foreach keyword to return its contents.
        //public IEnumerator GetEnumerator()
        //{
        //    yield return employees[0];
        //    yield return employees[1];
        //    yield return employees[2];
        //    yield return employees[3];
        //}
    }
}