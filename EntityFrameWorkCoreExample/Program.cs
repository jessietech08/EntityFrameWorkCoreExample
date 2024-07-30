using EntityFrameWorkCoreExample;

using StudentContext dbContext = new();

// add with EF Core
Student s = new()
{
    FullName = "Jessie Sumandig",
    EmailAddress = "jessie.sumandig@cptc.edu",
    DateOfBirth = new DateTime(2003, 7, 8),
};

Student s2 = new()
{
    FullName = "Jim Halpert",
    EmailAddress = "jim.halpert@cptc.edu",
    DateOfBirth = new DateTime(2003, 7, 8),
};

dbContext.Students.Add(s); // prepares the Student insert statement
dbContext.SaveChanges(); // executes pending insert. (In Actuality: execute any pending insert/update/delete)

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// retrieve Students from db
List<Student> allStudents = dbContext.Students.ToList(); // method syntax
//allStudents = (from stu in dbContext.Students
//               select.stu).ToList(); // query syntax
foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}