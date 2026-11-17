# region question1
//1
using System.Text;

string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);

#endregion
#region question2
//2
string str1 = "clean code";
string str2 = "clean code";
Console.WriteLine(ReferenceEquals(str1, str2));
#endregion

#region question3
//3

StringBuilder books = new StringBuilder();
books.Append("Booklist");
books.Append(" _updated");
Console.WriteLine(books);
#endregion
#region question4
//4

books.Replace("Booklist", "library");
Console.WriteLine(books);
#endregion

#region question5
//5
string titlee = "CleanCode";
int pages = 464;
string result1 = "title:" + titlee + "," + "pages:" + pages;
string result2 = $"title:{titlee},pages:{pages}";
string result3 = string.Format("title:{0},pages:{1}", titlee, pages);
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

#endregion
#region question6
//6
int pagees = 464;
if (pagees > 300)
{
    Console.WriteLine("loog Book");
}
else
{
    Console.WriteLine("short Book");
}
#endregion
#region question7
//7
int pagess = 464;
bool isAvailable = true;
if (pagess > 300 && isAvailable == true)
{
    Console.WriteLine("you can borrow box");
}
#endregion
#region question8
//8

string tiitle = "Refactoring";

switch (tiitle)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}
#endregion
#region question9
//9
int paages = 464;
string sizeLabel = paages > 300 ? "longbook" : "shortBook";
Console.WriteLine(sizeLabel);
#endregion
#region question10
//10
string[] bookss = { "cleanCode", "theProgramaticprogrammer", "Refactoring" };
for (int ii = 0; ii < bookss.Length; ii++)
{
    Console.WriteLine((ii + 1) + "." + bookss[ii]);
}
#endregion
#region question11
//11
string[] boooks = {
    "CleanCode",
    "ThePragmaticProgrammer",
    "Refactoring"
};

int i = 0;
while (i < boooks.Length)
{
    Console.WriteLine(boooks[i]);
    i++;
}
#endregion
#region question12
//12
int j = 0;

do
{
    Console.WriteLine("Checking book...");
    j++;
}
while (j < 3);
#endregion
#region question13
//13
string[] bbooks = {
    "CleanCode",
    "ThePragmaticProgrammer",
    "Refactoring"
};

foreach (string book in bbooks)
{
    Console.WriteLine(book);
}
#endregion
#region question14
//14
string[] bookks = {
    "CleanCode",
    "ThePragmaticProgrammer",
    "Refactoring"
};

foreach (string book in bookks)
{
    if (book == "Refactoring")
    {
        break;
    }
    Console.WriteLine(book);
}

#endregion
#region question15
//15
string[] baooks = {
    "CleanCode",
    "ThePragmaticProgrammer",
    "Refactoring"
};

foreach (string book in baooks)
{
    if (book == "Refactoring")
    {
        continue;
    }
    Console.WriteLine(book);
}

#endregion
