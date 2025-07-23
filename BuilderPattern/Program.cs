using BuilderPattern;

var items = new List<FurnitureItem>
{
    new FurnitureItem("Sectional couch", 55.5, 22.4, 78.6, 35.0),
    new FurnitureItem("Nightstand", 25.0, 12.4, 20.0, 10.0),
    new FurnitureItem("Dining table", 105.0, 35.4, 100.6, 55.5)
};

var builder = new DailyReportBuilder(items);
//var director = new InventoryBuildDirector(builder);

//director.BuildCompleteReport();
//var report = builder.GetDailyReport();
//Console.WriteLine(report.Debug());

var fluentReport = builder.AddTitle().AddDimensions().AddLogistics(DateTime.Now).GetDailyReport();

Console.WriteLine(fluentReport.Debug());
