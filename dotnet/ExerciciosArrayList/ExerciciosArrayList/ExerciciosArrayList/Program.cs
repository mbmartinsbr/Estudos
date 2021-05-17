using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciciosArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o Programa");
            Console.WriteLine("1 - Exercicio de Fixação");
            Console.WriteLine("2 - Exercicio de Matriz");
            if (Console.ReadLine() == "1")
            {
                Fixacao();
            }
            else
            {
                Matrix();
            }
        }
        static void Fixacao()
        {
            Console.Write("How many employees will be registered ?");
            int employesCount = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employesCount; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            int pos1 = employees.FindIndex(x => x.Id == idIncrease);
            if (pos1 != -1)
            {
                Console.Write("Enter the percentage: ");
                double salaryIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees[pos1].increaseSalary(salaryIncrease);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");

            foreach (object obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
        static void Matrix()
        {
            string[] vet = Console.ReadLine().Split(" ");

            int[,] matr = new int[int.Parse(vet[0]), int.Parse(vet[1])];

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                string[] vet2 = Console.ReadLine().Split(" ");
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = int.Parse(vet2[j]);
                }
            }

            int num1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] == num1)
                    {
                        Console.WriteLine($"Position: {i},{j}");

                        if ((j - 1) >= 0 && matr.GetLength(0) >= (j - 1) && matr[i, (j - 1)] > 0)
                        {
                            Console.WriteLine($"Left: {matr[i, (j - 1)]}");
                        }

                        if ((i - 1) >= 0 && matr.GetLength(1) >= (i - 1) && matr[(i - 1), j] > 0)
                        {
                            Console.WriteLine($"Up: {matr[(i - 1), j]}");
                        }

                        if (matr.GetLength(0) >= (j + 1) && matr[i, (j + 1)] > 0)
                        {
                            Console.WriteLine($"Right: {matr[i, (j + 1)]}");
                        }

                        if (matr.GetLength(1) >= (i + 1) && matr[(i + 1), j] > 0)
                        {
                            Console.WriteLine($"Down: {matr[(i + 1), j]}");
                        }

                    }
                }

            }
        }
    }
}
