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
            //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q03
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = arr
            //    .Select((word, index) => new { word, index })
            //    .Where(x => x.word.Length < x.index)
            //    .Select(x => x.index);

            //Console.WriteLine("Digits whose name is shorter than their value: " + string.Join(", ", result));
            #endregion
            #endregion

            #region LINQ Element Operator
            #region Q01
            var result = ProductsList.First(p=>p.UnitsInStock==0);
            Console.WriteLine(result);
            #endregion
            #endregion
        }
    }
}
