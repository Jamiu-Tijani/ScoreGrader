Console.WriteLine("*******************************************");
Console.WriteLine("**                                       **");
Console.WriteLine("**       Welcome to Score grader 1.0     **");
Console.WriteLine("**                                       **");
Console.WriteLine("*******************************************");
Console.Write("Please Input Student Score : ");
int studentScore;
studentScore = Convert.ToInt32(Console.ReadLine());

if (studentScore > 100)
{
    Console.WriteLine("REDUCE THIS VALUE, INPUT FROM 0 - 100");
    return;
}
if (studentScore >= 70)
{
    Console.WriteLine("Student Score is A. Very Demure Very Mindful.");
    return;
}
if (studentScore <= 69 && 60 <= studentScore)
{
    Console.WriteLine("Student Score is B. Demure And Mindful.");
    return;
}
if (studentScore <= 59 && 50 <= studentScore)
{
    Console.WriteLine("Student Score is C. Demure But Not Mindful Please be careful work harder.");
    return;
}
if (studentScore <= 49 && 40 <= studentScore)
{
    Console.WriteLine("Student Score is D. Demonic and Terrible Think About Your Life.");
    return;
}

if (studentScore <= 39 && 0 <= studentScore)
{
    Console.WriteLine("Student Score is F. Advised to Withdraw You're One Step Out Of School.");
    return;
}

if (studentScore < 0)
{
    Console.WriteLine("I Commend Your Bravery For Inputting Such Attrocious Score. Please Input Normal Score From 0 - 100");
    return;
}