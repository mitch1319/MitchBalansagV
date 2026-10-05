using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Problem4_Stack
{
    static void Main()
    {
        Stack<Operation> operationHistory = new Stack<Operation>();

        operationHistory.Push(new Operation
        {
            Action = "Deleted",
            StudentNumber = "2024-004",
            StudentName = "Pedro"
        });

        operationHistory.Push(new Operation
        {
            Action = "Updated",
            StudentNumber = "2024-001",
            StudentName = "Juan"
        });

        operationHistory.Push(new Operation
        {
            Action = "Added",
            StudentNumber = "2024-002",
            StudentName = "Maria"
        });

        operationHistory.Push(new Operation
        {
            Action = "Added",
            StudentNumber = "2024-001",
            StudentName = "Juan"
        });

        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("              OPERATION HISTORY             ");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("1. View Operation History");
            Console.WriteLine("2. View Last Operation");
            Console.WriteLine("3. Remove Last Operation");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            Console.Write("Enter choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("\nInvalid input. Please enter a number from 1 to 4.");
                continue;
            }

            Console.WriteLine();

            if (choice == 1)
            {
                Console.WriteLine("OPERATION HISTORY");
                Console.WriteLine();

                int index = 1;

                foreach (Operation op in operationHistory)
                {
                    Console.WriteLine($"{index}. {op.Action} {op.StudentName}");
                    index++;
                }
            }
            else if (choice == 2)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations.");
                }
                else
                {
                    Operation lastOp = operationHistory.Peek();
                    Console.WriteLine(
                        $"Last Operation: {lastOp.Action} {lastOp.StudentName}"
                    );
                }
            }
            else if (choice == 3)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No recorded operations to remove.");
                }
                else
                {
                    operationHistory.Pop();
                    Console.WriteLine("Last operation removed successfully!");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose between 1 and 4.");
            }

            if (choice != 4)
            {
                Console.WriteLine();
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
