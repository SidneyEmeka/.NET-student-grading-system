// See https://aka.ms/new-console-template for more information

/*You're developing a Student Grading application that automates the calculation of current grades for each student in a class. The parameters for your application are:

You're given a short list of four students and their five assignment grades.
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
Final scores are calculated as an average of the five assignment scores.
Your application needs to perform basic math operations to calculate the final grades for each student.
Your application needs to output/display each student’s name and final score.
The teacher requires that the calculated grades for each student are displayed as follows:


Copy
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A
*/
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

decimal Sophia = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (decimal)currentAssignments;


decimal Nicolas = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (decimal)currentAssignments;


decimal Zahirah = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (decimal)currentAssignments;


decimal Jeong = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (decimal)currentAssignments;


Console.WriteLine("Student\t\tGrade");
Console.WriteLine("Sophia\t\t" + Sophia + "\tA");
Console.WriteLine("Nicolas\t\t" + Nicolas + "\tB");
Console.WriteLine("Zahirah\t\t" + Zahirah + "\tB");
Console.WriteLine("Jeong\t\t" +Jeong + "\tA");





