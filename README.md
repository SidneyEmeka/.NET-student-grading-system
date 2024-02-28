# .NET-student-grading-program
A Student Grading application that automates the calculation of current grades for each student in a class. The parameters for the application are:<br>

The code automatically assigns a student's letter grade based on their final numeric score.<br>
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
Each student has five assignment grades, and also an opportunity to take extra credit assignments.<br>
The first five grades are the Assignment grades then the rest are the extra credit scores.<br>
Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.<br>
Extra credit assignments will be worth 10% of an exam score when applied toward the final numeric grade.<br>
Extra credit assignment scores must be added to the student's total exam score before calculating the final numeric grade.<br>
Final scores are calculated as an average of the five assignment scores.<br>

The teacher requires that the calculated grades for each student are displayed as follows:
<br>
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)<br>
Check program.cs file for the program code

## Foreach Loop
