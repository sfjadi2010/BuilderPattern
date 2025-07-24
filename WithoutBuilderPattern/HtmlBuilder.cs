namespace WithoutBuilderPattern;

public class HtmlBuilder
{
    private readonly string rootName;
    HtmlElement root = new HtmlElement();

    public HtmlBuilder(string rootName)
    {
        ArgumentNullException.ThrowIfNull(rootName, "rootName");
        this.rootName = rootName;
        root.Name = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        ArgumentNullException.ThrowIfNull(childName, "childName");
        ArgumentNullException.ThrowIfNull(childText, "childText");
        root.Elements.Add(new HtmlElement(childName, childText));
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void Clear()
    {
        root = new HtmlElement { Name = rootName };
    }
}
