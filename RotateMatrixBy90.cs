namespace PracticePrograms3
{
    internal class RotateMatrixBy90
    {
        static void Main(string[] args)
        {
           
            int[,] arr = { { 1,2,3},
                            {4,5,6 },
                            {7,8,9 }};

            rotateArr(arr);
        }
        public static void rotateArr(int[,] arr)
        {
            int[,] arrRotate = new int[3, 3];
            int rows = 3, cols = 3, count = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j=0; j < cols; j++)
                {
                    arrRotate[j, rows-1 -count] = arr[i,j];
                }
                //cols--;
                count++;


            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arrRotate[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}