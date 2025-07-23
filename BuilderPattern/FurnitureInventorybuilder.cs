namespace BuilderPattern;
internal class DailyReportBuilder : IFurnitureInventoryBuilder
{
    private InventoryReport _inventoryReport;
    private IEnumerable<FurnitureItem> _items;

    public DailyReportBuilder(IEnumerable<FurnitureItem> items)
    {
        Reset();
        _items = items;
    }

    public void Reset()
    {
        _inventoryReport = new InventoryReport();
    }

    public IFurnitureInventoryBuilder AddDimensions()
    {
        _inventoryReport.DimensionsSection = string.Join("", _items.Select(p =>
            $"Product: {p.Name}\nPrice: {p.Price}\nHeight: {p.Height} x Width: {p.Width} -> Weight: {p.Weight}lbs\n\n"));

        return this;
    }

    public IFurnitureInventoryBuilder AddLogistics(DateTime dateTime)
    {
        _inventoryReport.LogisticsSection = $"Report generated on {dateTime}";

        return this;
    }

    public IFurnitureInventoryBuilder AddTitle()
    {
        _inventoryReport.TitleSection = "------- Daily Inventory Report -------\n\n";

        return this;
    }

    public InventoryReport GetDailyReport()
    {
        InventoryReport finishedReport = _inventoryReport;
        Reset();
        return finishedReport;
    }
}
