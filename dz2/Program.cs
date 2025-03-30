using System;
using System.Linq;

namespace dz5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task1
            //Console.WriteLine("Task 1:");
            //Random rnd = new Random();
            //int[] A = new int[5];
            //int[,] B = new int[3, 4];
            //int maxB = 0;
            //int minB = 100;
            //int sumB = 0;
            //long multiB = 1;
            //long multiA = 1;
            //int pairA = 0;
            //int unPairB = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Write value for num {i + 1}: ");
            //    int tempNum = Convert.ToInt32(Console.ReadLine());
            //    A[i] = tempNum;
            //    multiA *= A[i];
            //    if ((i + 1) % 2 == 0)
            //    {
            //        pairA += tempNum;
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        B[i, j] = rnd.Next(1, 100);
            //        if (B[i, j] > maxB)
            //        {
            //            maxB = B[i, j];
            //        }
            //        if (B[i, j] < minB)
            //        {
            //            minB = B[i, j];
            //        }
            //        sumB += B[i, j];
            //        multiB *= B[i, j];
            //        if ((j + 1) % 2 == 0)
            //        {
            //            unPairB += B[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("\nArray A: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine("\n\nArray B: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("\nThe biggest: ");
            //if (maxB > A.Max())
            //{
            //    Console.WriteLine(maxB);
            //}
            //else
            //{
            //    Console.WriteLine(A.Max());
            //}
            //Console.Write("\nThe smallest: ");
            //if (minB < A.Min())
            //{
            //    Console.WriteLine(minB);
            //}
            //else
            //{
            //    Console.WriteLine(A.Min());
            //}
            //Console.Write($"\nSum: {A.Sum() + sumB}");
            //Console.Write($"\n\nMulti: {multiA * multiB}");
            //Console.Write($"\n\nPair A: {pairA}");
            //Console.Write($"\n\nUnpair B: {unPairB}");
            //
            ////Task2
            //Console.WriteLine("\n\nTask 2:\n");
            //int[,] arr = new int[5, 5];
            //int maxArr = 0;
            //int minArr = 100;
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arr[i, j] = rnd.Next(1, 100);
            //        if (arr[i, j] > maxArr)
            //        {
            //            maxArr = arr[i, j];
            //        }
            //        if (arr[i, j] < minArr)
            //        {
            //            minArr = arr[i, j];
            //        }
            //        sum += arr[i, j];
            //    }
            //}
            //Console.WriteLine("sum"+(sum-maxArr-minArr));
            //Task3
            //
            //Console.Write("Write a sentence: ");
            //string sentence = Console.ReadLine();
            //Console.Write("Write a step: ");
            //int step = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if ((int)(sentence[i]) >= 65 && (int)(sentence[i]) <= 90 || (int)(sentence[i]) >= 97 && (int)(sentence[i]) <= 122)
            //    {
            //        char shiftedChar = (sentence[i] >= 'a') ? (char)(((((((int)(sentence[i]) - 97) + step) % 26) + 26) % 26) + 97) : (char)(((((((int)(sentence[i]) - 65) + step) % 26) + 26) % 26) + 65);
            //
            //        Console.Write(shiftedChar);
            //    }
            //    else
            //    {
            //        Console.Write(sentence[i]);
            //    }
            //}
            //Console.Read();
            //Task4
            //Console.WriteLine("Enter the size of the matrix (rows and columns): ");
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //
            //int[,] matrix1 = new int[rows, cols];
            //int[,] matrix2 = new int[rows, cols];
            //int[,] result = new int[rows, cols];
            //
            //Console.WriteLine("Enter the elements of the first matrix:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"[{i},{j}]: ");
            //        matrix1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //
            //Console.WriteLine("Enter the elements of the second matrix:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"[{i},{j}]: ");
            //        matrix2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //
            //Console.Write("Enter a number to multiply the first matrix: ");
            //int num = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine("Matrix 1 multiplied by the number:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        result[i, j] = matrix1[i, j] * num;
            //        Console.Write(result[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //
            //Console.WriteLine("Sum of matrices:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        result[i, j] = matrix1[i, j] + matrix2[i, j];
            //        Console.Write(result[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //
            //Console.WriteLine("Product of matrices:");
            //int sumLength = matrix1.GetLength(1);
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        int sum = 0;
            //        for (int k = 0; k < sumLength; k++)
            //        {
            //            sum += matrix1[i, k] * matrix2[k, j];
            //        }
            //        result[i, j] = sum;
            //        Console.Write(result[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Task5
            //Console.Write("Enter an arithmetic expression (+ and - only): ");
            //string expression = Console.ReadLine();
            //
            //int result = 0;
            //int currentNumber = 0;
            //int sign = 1;
            //
            //for (int i = 0; i < expression.Length; i++)
            //{
            //    char currentChar = expression[i];
            //
            //    if (Char.IsDigit(currentChar))
            //    {
            //        currentNumber = currentNumber * 10 + (currentChar - '0');
            //    }
            //    else if (currentChar == '+' || currentChar == '-')
            //    {
            //        result += sign * currentNumber;
            //        sign = (currentChar == '+') ? 1 : -1;
            //        currentNumber = 0;
            //    }
            //}
            //
            //result += sign * currentNumber;
            //Console.WriteLine("Result: " + result);
            //Task6
            //Console.Write("Enter a text: ");
            //string text = Console.ReadLine();
            //
            //string[] sentences = text.Split(new[] { ". ", "? ", "! " }, StringSplitOptions.None);
            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    if (sentences[i].Length > 0)
            //    {
            //        sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            //    }
            //}
            //
            //string result = string.Join(". ", sentences);
            //if (text.EndsWith(".") || text.EndsWith("?") || text.EndsWith("!"))
            //{
            //    result += text[text.Length - 1];
            //}
            //
            //Console.WriteLine(result);
            //Task7
            //string forbiddenWord = "die";
            //int count = 0;
            //
            //Console.WriteLine("Enter a text:");
            //string text = Console.ReadLine();
            //
            //string[] words = text.Split(new[] { ' ', '.', ',', '?', '!', ';', ':', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            //
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (string.Equals(words[i], forbiddenWord, StringComparison.OrdinalIgnoreCase))
            //    {
            //        text = text.Replace(words[i], new string('*', words[i].Length));
            //        count++;
            //    }
            //}
            //
            //Console.WriteLine("Modified text:");
            //Console.WriteLine(text);
            //Console.WriteLine($"Statistic: {count} replacement(s) of the word '{forbiddenWord}'.");
            //Task8
            //
            //Console.Write("Write a sentence: ");
            //string sentence = Console.ReadLine();
            //Console.Write("Write a step: ");
            //int step = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if ((int)(sentence[i]) >= 65 && (int)(sentence[i]) <= 90 || (int)(sentence[i]) >= 97 && (int)(sentence[i]) <= 122)
            //    {
            //        char shiftedChar = (sentence[i] >= 'a') ? (char)(((((((int)(sentence[i]) - 97) + step) % 26) + 26) % 26) + 97) : (char)(((((((int)(sentence[i]) - 65) + step) % 26) + 26) % 26) + 65);
            //
            //        Console.Write(shiftedChar);
            //    }
            //    else
            //    {
            //        Console.Write(sentence[i]);
            //    }
            //}
            //Console.Read();
            //Task9
            //int rows = int.Parse(args[0]);
            //int cols = int.Parse(args[1]);
            //int factor = int.Parse(args[2]);
            //
            //int[,] array = new int[rows, cols];
            //Random rand = new Random();
            //
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < cols; j++)
            //        array[i, j] = rand.Next(1, 10);
            //
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < cols; j++)
            //        array[i, j] *= factor;
            //
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //        Console.Write(array[i, j] + "\t");
            //    Console.WriteLine();
            //}

        }

    }

}
