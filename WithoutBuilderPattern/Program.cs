// See https://aka.ms/new-console-template for more information
using System.Text;
using WithoutBuilderPattern;

string hello = "Hello";

StringBuilder sb = new StringBuilder();
sb.Append("<p>");
sb.Append(hello);
sb.Append("</p>");
Console.WriteLine(sb);

string[] words = { "Hello", "World" };
sb.Clear();
sb.Append("<ul");

foreach (string word in words)
{
    sb.AppendFormat("<li>{0}</li>", word);
}
sb.Append("</ul");
Console.WriteLine(sb);

HtmlBuilder builder = new HtmlBuilder("ul");
builder.AddChild("li", "Hello");
builder.AddChild("li", "World");
Console.WriteLine(builder);
