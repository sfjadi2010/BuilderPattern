namespace BuilderPattern;

public sealed class InventoryReport
{
    public string TitleSection;
    public string DimensionsSection;
    public string LogisticsSection;

    public string Debug() => $"{TitleSection}\n{DimensionsSection}\n{LogisticsSection}";
}
