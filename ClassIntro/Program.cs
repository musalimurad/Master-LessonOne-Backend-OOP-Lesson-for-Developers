
Course courseOne = new();
courseOne.ID = 1;
courseOne.CourseName = "C#";
courseOne.Teacher = "Musali Murad";
courseOne.ViewCourse = 3000;

Course courseTwo = new();
courseTwo.ID = 2;
courseTwo.CourseName = "Node.js";
courseTwo.Teacher = "Musali Murad";
courseTwo.ViewCourse = 2400;


Course courseThree = new()
{
    ID = 3,
    CourseName = "React",
    Teacher = "Musali Murad",
    ViewCourse = 7000
};


class Course
{
    public int ID { get; set; }

    public string CourseName { get; set; }

    public string Teacher { get; set; }

    public int ViewCourse { get; set; }

}

