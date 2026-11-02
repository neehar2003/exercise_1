using System.Collections.Generic;

var title = new List<string>
{
    
"Write README",
"Add unit tests",
"Review PR",
"Set up docker",
"Fix login bug"

};

Console.WriteLine(string.Join(", ", title));

title.Add("Deploy to test");

Console.WriteLine(string.Join(", ", title));

title.Remove("Review PR");

Console.WriteLine(string.Join(", ", title));

title.Sort();

Console.WriteLine(string.Join(", ", title));

var first = title.Find(t => t.Contains("test",StringComparison.OrdinalIgnoreCase));
Console.WriteLine(first);
















/*record Ticket(string Title, string Owner, string State);
var tickets = new List<Ticket>
{
 new("Write README", "Asha", "Done"),
 new("Add unit tests", "Asha", "InProgress"),
 new("Review PR", "Ravi", "ToDo"),
 new("Set up Docker", "Ravi", "ToDo"),
 new("Fix login bug", "Meera", "InProgress"),
};*/