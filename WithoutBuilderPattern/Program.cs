// See https://aka.ms/new-console-template for more information
using System.Text;

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
