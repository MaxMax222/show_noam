namespace Show_Noam_Git;
class Program
{
    static void Main(string[] args)
    {
        int[,] mat = new int[10, 10];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
