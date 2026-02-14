using DesignPatternChallengBuilder.Product;

namespace DesignPatternChallengBuilder.Interface
{
    public interface ISalesReportBuilder
    {
        void SetTitle(string title);
        void SetFormat(string format);
        void SetStartDate(DateTime startDate);
        void SetEndDate(DateTime endDate);
        void IncludeHeader();
        void IncludeFooter();
        void SetHeaderText(string headerText);
        void SetFooterText(string footerText);
        void IncludeCharts();
        void SetChartType(string charType);
        void IncludeSummary();
        void SetColumns(List<string> coluns);
        void SetFilters(List<string> filters);
        void SetSortBy(string sortBy);
        void SetGroupBy(string groupBy);
        void IncludeTotals();
        void SetOrientation(string orientation);
        void SetPageSize(string pageSize);
        void IncludePageNumbers();
        void SetCompanyLogo(string companyLogo);
        void SetWaterMark(string waterMark);
        SalesReport Build();
    }
}
