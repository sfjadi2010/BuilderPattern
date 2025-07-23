namespace BuilderPattern;

internal class InventoryBuildDirector
{
    private IFurnitureInventoryBuilder _builder;

    public InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
    {
        _builder = concreteBuilder;
    }

    public void BuildCompleteReport()
    {
        _builder.AddTitle();
        _builder.AddDimensions();
        _builder.AddLogistics(DateTime.Now);
    }
}
