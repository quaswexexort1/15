public class Matrix
{
    public static void Main(string[] args)
    {
        double[,] matrixA =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double normM = CalculateNormM(matrixA);
        double normL = CalculateNormL(matrixA);

        Console.WriteLine($"||A||m: {normM}");
        Console.WriteLine($"||A||l: {normL}");


    }

    // ||A||m (максимальная сумма по строкам)
    static double CalculateNormM(double[,] matrix)
    {
        double maxRowSum = 0;
        int rows = matrix.GetLength(0);
        for (int i = 0; i < rows; i++)
        {
            double rowSum = 0;
            for (int j = 0; j < rows; j++)
            {
                rowSum += Math.Abs(matrix[i, j]);
            }
            maxRowSum = Math.Max(maxRowSum, rowSum);
        }
        return maxRowSum;
    }

    // ||A||l (максимальная сумма по столбцам)
    static double CalculateNormL(double[,] matrix)
    {
        double maxColSum = 0;
        int cols = matrix.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            double colSum = 0;
            for (int i = 0; i < cols; i++)
            {
                colSum += Math.Abs(matrix[i, j]);
            }
            maxColSum = Math.Max(maxColSum, colSum);
        }
        return maxColSum;
    }
}

