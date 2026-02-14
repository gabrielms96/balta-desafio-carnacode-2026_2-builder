using DesignPatternChallengBuilder.Interface;
using DesignPatternChallengBuilder.Product;

namespace DesignPatternChallengBuilder.Director
{
    public class SalesReportDirector
    {
        public void MonthlySalesReport(ISalesReportBuilder builder)
        {
            var Filters = new List<string> { "Status=Ativo" };
            var Columns = new List<string> { "Produto", "Quantidade", "Valor" };
            builder.SetTitle("Vendas Mensais");
            builder.SetFormat("PDF");
            builder.SetStartDate(new DateTime(2024, 1, 1));
            builder.SetEndDate(new DateTime(2024, 1, 31));
            builder.IncludeHeader();
            builder.IncludeFooter();
            builder.SetHeaderText("Relatório de Vendas");
            builder.SetFooterText("Confidencial");
            builder.IncludeCharts();
            builder.SetChartType("Bar");
            builder.IncludeSummary();
            builder.SetColumns(Columns);
            builder.SetFilters(Filters);
            builder.SetSortBy("Valor");
            builder.SetGroupBy("Categoria");
            builder.IncludeTotals();
            builder.SetOrientation("Portrait");
            builder.SetPageSize("A4");
            builder.IncludePageNumbers();
            builder.SetCompanyLogo("logo.png");
            builder.SetWaterMark("Confidencial");
            builder.SetFormat("PDF");
            builder.SetStartDate(DateTime.Now.AddMonths(-1));
            builder.SetEndDate(DateTime.Now);
            builder.IncludeHeader();
            builder.IncludeFooter();
            builder.SetHeaderText("Relatório Mensal de Vendas");
            builder.SetFooterText("Confidencial - Para Uso Interno");
            builder.IncludeCharts();
            builder.SetChartType("Bar");
            builder.IncludeSummary();
            builder.SetColumns(new List<string> { "Produto", "Quantidade", "Valor" });
            builder.SetFilters(new List<string> { "Data >= 01/01/2024", "Data <= 31/01/2024" });
            builder.SetSortBy("Valor");
            builder.SetGroupBy("Produto");
            builder.IncludeTotals();
            builder.SetOrientation("Portrait");
            builder.SetPageSize("A4");
            builder.IncludePageNumbers();
            builder.SetCompanyLogo("logo.png");
            builder.SetWaterMark("Confidencial");

            Generate(builder.Build());
        }

        public void TrimesterSalesReport(ISalesReportBuilder builder)
        {
            var Columns = new List<string> { "Vendedor", "Região", "Total" };
            builder.SetTitle("Relatório Trimestral");
            builder.SetHeaderText("Relatório Trimestral de Vendas");
            builder.SetFormat("Excel");
            builder.SetGroupBy("Região");
            builder.SetChartType("Line");
            builder.SetColumns(Columns);
            builder.SetStartDate(new DateTime(2024, 1, 1));
            builder.SetEndDate(new DateTime(2024, 3, 31));
            builder.IncludeCharts();
            builder.IncludeHeader();
            builder.IncludeTotals();

            Generate(builder.Build());
        }

        public void AnnualSalesReport(ISalesReportBuilder builder)
        {
            // Problema 3: Relatórios com configurações parecidas exigem repetir muito código
            var Columns = new List<string> { "Produto", "Quantidade", "Valor" };
            builder.SetTitle("Vendas Anuais");
            builder.SetFormat("PDF");
            builder.SetStartDate(new DateTime(2024, 1, 1));
            builder.SetEndDate(new DateTime(2024, 12, 31));
            builder.IncludeHeader();
            builder.SetHeaderText("Relatório de Vendas");
            builder.IncludeFooter();
            builder.SetFooterText("Confidencial");
            builder.SetColumns(Columns);
            builder.IncludeCharts();
            builder.SetChartType("Pie");
            builder.IncludeTotals();
            builder.SetOrientation("Landscape");
            builder.SetPageSize("A4");

            Generate(builder.Build());
        }

        private static void Generate(SalesReport report)
        {
            Console.WriteLine($"\n=== Gerando Relatório: {report.Title} ===");
            Console.WriteLine($"Formato: {report.Format}");
            Console.WriteLine($"Período: {report.StartDate:dd/MM/yyyy} a {report.EndDate:dd/MM/yyyy}");

            if (report.IncludeHeader)
                Console.WriteLine($"Cabeçalho: {report.HeaderText}");

            if (report.IncludeCharts)
                Console.WriteLine($"Gráfico: {report.ChartType}");

            Console.WriteLine($"Colunas: {string.Join(", ", report.Columns)}");

            if (report.Filters.Count > 0)
                Console.WriteLine($"Filtros: {string.Join(", ", report.Filters)}");

            if (!string.IsNullOrEmpty(report.GroupBy))
                Console.WriteLine($"Agrupado por: {report.GroupBy}");

            if (report.IncludeFooter)
                Console.WriteLine($"Rodapé: {report.FooterText}");

            Console.WriteLine("Relatório gerado com sucesso!");
            Console.WriteLine("==============================\n");
        }
    }
}
