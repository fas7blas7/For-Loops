⭐ My C# For Loop Coding Tasks

Welcome to my GitHub repository! Here, you'll find various C# coding tasks with structured numbering and detailed solutions. 💻✨

🐜 Introduction

This repository contains small but essential C# programs that focus on fundamental concepts like loops, conditionals, and input/output handling. Each task is numbered and documented for easy reference.

📎 Folder Structure

/MyCodingTasks
│—— /Task1_NumbersInRange
│    ├—— NumbersInRange.cs
│—— /Task2_FirstXNumbersSum
│    ├—— FirstXNumbersSum.cs
│—— /Task3_SumNumbers
│    ├—— SumNumbers.cs
│—— /Task4_NumbersEndingIn7
│    ├—— NumbersEndingIn7.cs
│—— /Task5_Numbers_From_1_To_N_Over_3
│    ├—— NumbersFrom1ToNOver3.cs
│—— /Task6_Exam_Countdown
│    ├—— ExamCountdown.cs
│—— /Task7_LatinLetters
│    ├—— LatinLetters.cs
│—— README.md

Each task is stored in a separate folder named according to its purpose. The .cs files contain the C# source code for each task.

🛠️ Setup & Usage

🔧 Prerequisites

    Install .NET SDK (if not already installed)
    Use any C#-compatible editor (e.g., Visual Studio, VS Code)

▶️ Running a Task

    Open a terminal or command prompt.
    Navigate to the task directory:

    cd Task1_NumbersInRange

Compile the program:

    dotnet build

Run the executable:

    dotnet run

    Enter input when prompted, and see the output in the console!

📌 Task List

1️⃣ Numbers in Range 💲

Namespace: _1_NumbersInRange
📌 Description:
Prints all numbers between two given integers (inclusive).

2️⃣ First X Numbers Sum ➕

Namespace: _2_FirstXNumbersSum
📌 Description:
Calculates the sum of the first n natural numbers and prints it in a formatted way (e.g., 1+2+3=6).

3️⃣ Sum of N Numbers 🧙‍♂️

Namespace: _3_SumNumbers
📌 Description:
Reads n numbers from the console, calculates their sum, and prints the result.

4️⃣ Numbers Ending in 7 7⃣

Namespace: _4_NumbersEndingIn7
📌 Description:
Prints all numbers from 1 to a given number that end in 7.

📝 Code:
```csharp
namespace _4_NumbersEndingIn7
{
    internal class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endOfRange; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
```

5️⃣ Numbers From 1 To N Over 3 📏

Namespace: _5_Numbers_From_1_To_N_Over_3
📌 Description:
Prints every third number from 1 to n.

📝 Code:
```csharp
namespace _5_Numbers_From_1_To_N_Over_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```

6️⃣ Exam Countdown ⏳

Namespace: _6_Exam_Countdown
📌 Description:
Counts down from a given number of days until an exam.

📝 Code:
```csharp
namespace _6_Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToExam = int.Parse(Console.ReadLine());

            for (int day = daysToExam; day >= 1; day--)
            {
                Console.WriteLine($"{day} days before the exam");
            }

            Console.WriteLine("The exam has come");
        }
    }
}
```

7️⃣ Latin Letters 🔤

Namespace: _7_LatinLetters
📌 Description:
Prints all Latin letters in a given range.

📝 Code:
```csharp
namespace _7_LatinLetters
{
    internal class LatinLetters
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            for(char i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
```

🎯 Commit Progress Tracker

🚀 Goal: 500 commits in 2025
📅 Current Progress: 334 commits

📊 Progress Bar:

██████████████████▒▒▒▒▒▒▒ 66.8% (334/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
🔲 400 commits
🔲 500 commits (🎉)

