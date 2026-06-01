class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int[,] tabA = new int[n, n];
        int[,] tabB = new int[n, n];
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    tabA[i, j] = j;
                
            }
        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                tabB[j, i] = tabA[i, j];
            }
        
        }
        




        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{tabA[i, j]}");
                


                
            }
            Console.WriteLine();
        }



        Console.WriteLine();
        Console.WriteLine();



        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                

                Console.Write($"{tabB[i, j]}");


            }
            Console.WriteLine();
        }




    }


    


}