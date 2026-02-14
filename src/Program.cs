using DesignPatternChallengBuilder.ConcreteBuilder;
using DesignPatternChallengBuilder.Director;

namespace DesignPatternChallengBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var director = new SalesReportDirector();
            var builder = new SalesReportBuilder();
            director.MonthlySalesReport(builder);
            director.TrimesterSalesReport(builder);
            director.AnnualSalesReport(builder);
        }
    }
}