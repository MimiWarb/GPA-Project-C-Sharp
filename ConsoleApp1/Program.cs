// In this unit, I've learnt how to use a .NET editor, basic C# syntax rules, math operations on variables
// creating literal values and declare variables of basic data types. 

// In this project, I'll be putting all those things to use by calculating a final GPA.

// https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-final-gpa/2-prepare
git remote add origin https://github.com/MimiWarb/GPA-Project.git

string studentName = "Sophia Johnson";
string course1 = "English 101";
string course2 = "Algebra 101";
string course3 = "Biology 101";
string course4 = "Computer Science 1";
string course5 = "Psychology 101";

int creditCourse1 = 3;
int creditCourse2 = 3;
int creditCourse3 = 4;
int creditCourse4 = 4;
int creditCourse5 = 3;

int grade1 = 4;
int grade2 = 3;
int grade3 = 3;
int grade4 = 3;
int grade5 = 4;

int englishGrade = creditCourse1 * grade1; 
int algebraGrade = creditCourse2 * grade2;
int biologyGrade = creditCourse3 * grade3;
int computerGrade = creditCourse4 * grade4;
int psychologyGrade  = creditCourse5 * grade5;

int totalGrade = englishGrade + algebraGrade + biologyGrade + computerGrade + psychologyGrade;
int totalCredit = creditCourse1 + creditCourse2 + creditCourse3 + creditCourse4 + creditCourse5;

decimal gpa = (decimal)totalGrade / (decimal)totalCredit;
decimal gpaRounded = Math.Round(gpa, 2);

Console.WriteLine($"Student: {studentName}");
Console.WriteLine($"\nCourse \t\t\tGrade \tCredit Hours");
Console.WriteLine($"{course1} \t\t{grade1} \t{creditCourse1}");
Console.WriteLine($"{course2} \t\t{grade2} \t{creditCourse2}");
Console.WriteLine($"{course3} \t\t{grade3} \t{creditCourse3}");
Console.WriteLine($"{course4}   \t{grade4} \t{creditCourse4}");
Console.WriteLine($"{course5} \t\t{grade5} \t{creditCourse5}");

Console.WriteLine($"\nFinal GPA: {gpaRounded}");

