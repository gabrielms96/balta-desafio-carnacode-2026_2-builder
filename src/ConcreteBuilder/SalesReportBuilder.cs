using DesignPatternChallengBuilder.Interface;
using DesignPatternChallengBuilder.Product;

namespace DesignPatternChallengBuilder.ConcreteBuilder
{
    public class SalesReportBuilder : ISalesReportBuilder
    {
        private SalesReport _salesReport = new SalesReport();
        public void IncludeCharts() => _salesReport.IncludeCharts = true;
        public void IncludeFooter() => _salesReport.IncludeFooter = true;
        public void IncludeHeader() => _salesReport.IncludeHeader = true;
        public void IncludePageNumbers() => _salesReport.IncludePageNumbers = true;
        public void IncludeSummary() => _salesReport.IncludeSummary = true;
        public void IncludeTotals() => _salesReport.IncludeTotals = true;
        public void SetPageSize(string pageSize) => _salesReport.PageSize = pageSize;
        public void SetChartType(string charType) => _salesReport.ChartType = charType;
        public void SetColumns(List<string> coluns) => _salesReport.Columns = coluns;
        public void SetCompanyLogo(string companyLogo) => _salesReport.CompanyLogo = companyLogo;
        public void SetEndDate(DateTime endDate) => _salesReport.EndDate = endDate;
        public void SetFilters(List<string> filters) => _salesReport.Filters = filters;
        public void SetFooterText(string footerText) => _salesReport.FooterText = footerText;
        public void SetFormat(string format) => _salesReport.Format = format;
        public void SetGroupBy(string groupBy) => _salesReport.GroupBy = groupBy;
        public void SetHeaderText(string headerText) => _salesReport.HeaderText = headerText;
        public void SetOrientation(string orientation) => _salesReport.Orientation = orientation;
        public void SetSortBy(string sortBy) => _salesReport.SortBy = sortBy;
        public void SetStartDate(DateTime startDate) => _salesReport.StartDate = startDate;
        public void SetTitle(string title) => _salesReport.Title = title;
        public void SetWaterMark(string waterMark) => _salesReport.WaterMark = waterMark;
        public SalesReport Build() => _salesReport;
    }
}
