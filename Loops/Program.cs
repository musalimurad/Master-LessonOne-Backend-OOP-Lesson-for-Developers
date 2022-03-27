

for (int i = 1; i < 6; i++)
{
    Console.WriteLine(i);
}


string courseOne = "C# programming";
string courseTwo = "Java programming";
string courseThree = "React programming";


Console.WriteLine(courseOne);
Console.WriteLine(courseTwo);
Console.WriteLine(courseThree);

Console.WriteLine("====================================");

//Arrays

string[] courses = new string[] { "C# programming", "Java programming", "React programming" };


//Loops + Arrays

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i]);
}

Console.WriteLine("====================================");


Console.WriteLine("Kurslar bitdi");

Console.WriteLine("====================================");

foreach (string course in courses)
{
    Console.WriteLine(course);
}