using static Assignment01LINQ.ListGenerator;
namespace Assignment01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ-Restriction - Operator
            #region Q01
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var unit in result) 
            //    Console.WriteLine(unit);
            #endregion

            #region Q02
            var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            foreach (var item in result)
                Console.WriteLine(item);
            #endregion

            #endregion
        }
    }
}
