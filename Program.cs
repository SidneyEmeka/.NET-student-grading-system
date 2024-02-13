
int currentAssignments = 5;
int[] sophia =  { 90, 86, 87, 98, 100, 94, 90 };
int[] nicolas = { 92, 89, 81, 96, 90, 89 };
int[] zahirah = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] jeong = { 90, 98, 92, 100, 97};

string[] studentNames = {"sophia", "nicolas", "zahirah", "jeong"};

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

 Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames)
{
    string currentStudent = name;
  if (currentStudent == "sophia") 
   {
studentScores = sophia;
   }
   else if (currentStudent == "nicolas")
   {
    studentScores = nicolas;
   }
   else if (currentStudent == "zahirah")
   {
    studentScores = zahirah;
   }
   else if (currentStudent == "jeong")
   {
    studentScores = jeong;
   }
    int sumAssScores = 0;
  foreach (int score in studentScores) 
{
    sumAssScores += score;
}
  decimal currentStudentGrade = (decimal)sumAssScores / currentAssignments;
   

if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

        else
        currentStudentLetterGrade = "F";

        Console.WriteLine($"{currentStudent}\t\t {currentStudentGrade} \t{currentStudentLetterGrade}");
}
