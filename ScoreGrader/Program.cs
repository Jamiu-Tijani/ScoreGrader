Console.WriteLine("*******************************************");
Console.WriteLine("**                                       **");
Console.WriteLine("**       Welcome to Score grader 1.0     **");
Console.WriteLine("**                                       **");
Console.WriteLine("*******************************************");
Console.Write("Please Input Student Score : ");
int studentScore;

studentScore = Convert.ToInt32(Console.ReadLine());
bool ValidateInput (int studentScore)
{
    if (studentScore > 100)
    {
        return false ;
    }
    else if (studentScore < 0)
    {
        return false;
    }
    return true ;
}
string GradeAndPrint (int studentScore)
{
    string grade = "NA";
    if (studentScore >= 70)
    {
        grade = "A";
    }
    if (studentScore <= 69 && 60 <= studentScore)
    {
        grade =  "B";
    }
    if (studentScore <= 59 && 50 <= studentScore)
    {
        grade = "C";
    }
    if (studentScore <= 49 && 40 <= studentScore)
    {
        grade =  "D";
    }

    if (studentScore <= 39 && 0 <= studentScore)
    {
        grade =  "F";
    }

    return grade;

}
void DisplayGrade(string grade)
{

    if (string.Equals(grade, "A"))
    {
        Console.WriteLine("Student Score is A. Very Demure Very Mindful.");
        return;
    }
    if (string.Equals(grade,"B"))
    {
        Console.WriteLine("Student Score is B. Demure And Mindful.");
        return;
    }
    if (string.Equals(grade, "C"))
    {
        Console.WriteLine("Student Score is C. Demure But Not Mindful Please be careful work harder.");
        return;
    }
    if (string.Equals(grade, "D"))
    {
        Console.WriteLine("Student Score is D. Demonic and Terrible Think About Your Life.");
        return;
    }

    if (string.Equals(grade, "F"))
    {
        Console.WriteLine("Student Score is F. Advised to Withdraw You're One Step Out Of School.");
        return;
    }

}

if (ValidateInput(studentScore))
{
    string grade = GradeAndPrint(studentScore);
    DisplayGrade(grade);
}
else
{
    Console.WriteLine("Invalid Input. Score should be from 0 - 100");
}