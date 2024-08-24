using System;

namespace NestedArrayForLoops
{
    class Program
    {
        static int[,] matrix = 
        { 
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 } 
        };

        static void Main(string[] args)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }
               
            }
            
            
            
            
            foreach (var item in matrix)
            {
                Console.Write(item + " ");
            }
            
        }
    }

}