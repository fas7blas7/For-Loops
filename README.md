🚀 My C# For Loop Coding Tasks

Welcome to my GitHub repository! Here, you'll find various C# coding tasks with structured numbering and detailed solutions. 💻✨
📜 Introduction

This repository contains small but essential C# programs that focus on fundamental concepts like loops, conditionals, and input/output handling. Each task is numbered and documented for easy reference.
📂 Folder Structure

/MyCodingTasks
│── /Task1_NumbersInRange
│    ├── NumbersInRange.cs
│── /Task2_FirstXNumbersSum
│    ├── FirstXNumbersSum.cs
│── /Task3_SumNumbers
│    ├── SumNumbers.cs
│── README.md

Each task is stored in a separate folder named according to its purpose. The .cs files contain the C# source code for each task.
⚙️ Setup & Usage
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
1️⃣ Numbers in Range 🔢

Namespace: _1_NumbersInRange
📌 Description:
Prints all numbers between two given integers (inclusive).
📄 Code:

namespace _1_NumbersInRange
{
    internal class NumbersInRange
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

2️⃣ First X Numbers Sum ➕

Namespace: _2_FirstXNumbersSum
📌 Description:
Calculates the sum of the first n natural numbers and prints it in a formatted way (e.g., 1+2+3=6).
📄 Code:

namespace _2_FirstXNumbersSum
{
    internal class FirstXNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;

                if(i < n)
                {
                    Console.Write(i + "+");
                }
                else
                {
                    Console.Write(i + "=");
                }
            }          

            Console.WriteLine(sum);
        }
    }
}

3️⃣ Sum of N Numbers 🧮

Namespace: _3_SumNumbers
📌 Description:
Reads n numbers from the console, calculates their sum, and prints the result.
📄 Code:

namespace _3_SumNumbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}

🎯 Commit Progress Tracker

🚀 Goal: 500 commits in 2025
📅 Current Progress: 327 commits

📊 Progress Bar:

█████████████████▒▒▒▒▒▒▒▒▒ 65% (327/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
🔲 400 commits
🔲 500 commits (🎉)
