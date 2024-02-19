//initialize Variables
int examAssignments = 5;
int[] sophia =  { 90, 86, 87, 98, 100, 94, 90 };
int[] nicolas = { 92, 89, 81, 6, 90, 89 };
int[] zahirah = { 90, 5, 87, 98, 68, 89, 89};
int[] jeong = { 90, 8, 92, 100, 97,50};
int[] logan =  { 90, 95, 87, 88, 96, 96 };
int[] becky =  { 92, 1, 90, 91, 92, 92, 92 };
int[] chris =  { 84, 86, 88, 90, 92, 94, 96 };
int[] eric =  { 2, 90, 100, 80, 90, 100, 90 };
int[] gregor =  { 0, 91, 0, 91, 1, 91, 91 };    

// Student names
string[] studentNames = {"sophia", "nicolas", "zahirah", "jeong", "logan", "becky", "chris", "eric", "gregor"};

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

//Display Header
 Console.WriteLine("Student\t\tExam Score\tOverall Grade\t\tExtra Credit\n");

 //Outer foreach loop to loop through student names
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
   else if (currentStudent == "logan")
    {
        studentScores = logan;
        }
   else if (currentStudent == "becky")
    {
        studentScores = becky;
        }
else if (currentStudent == "chris")
    {
        studentScores = chris;
        }
else if (currentStudent == "eric")
    {
        studentScores = eric;
        }
else if (currentStudent == "gregor")
    {
    studentScores = gregor;
    }


    int sumAssScores = 0; // initialize/reset the sum of scored assignments
    int gradedAssignments = 0; // initialize/reset a counter for the number of assignment
     int extraCredit =  0; //initialize the variable for the extra credit scores
     decimal examScores = 0; //initialize the variable for the exam scores
   int gradedextraAssignments = 0; // initialize/reset a counter for the number of extra scores
     
     /* 
    the inner foreach loop: 
    - sums the exam and extra credit scores
    - counts the extra credit assignments
    */
  foreach (int score in studentScores) // loop through the studentScores array and complete calculations for currentStudent
{ 
    gradedAssignments ++; // increment the assignment counter
   if (gradedAssignments <= examAssignments)
    {
    sumAssScores += score;   // add the exam score to the sum
    examScores += score;
    }

    else 
    {
        
        sumAssScores += score / 10; // add the extra credit points to the sum - bonus points equal to 10% of an exam score
       gradedextraAssignments ++; //increment the extra graded assignment
       extraCredit += score; 
    }

}
decimal extraScore = extraCredit/gradedextraAssignments;
  decimal currentStudentGrade = (decimal)(decimal)sumAssScores / examAssignments;
  decimal examScore = (decimal)examScores / examAssignments;

  

   

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

        Console.WriteLine($"{currentStudent}\t\t {examScore}\t\t {currentStudentGrade}\t{currentStudentLetterGrade}\t\t {extraScore} ({(decimal)currentStudentGrade - (decimal)examScore})");
}

