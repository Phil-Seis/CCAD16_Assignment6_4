//You are given an nxn 2D matrix representing an image. Rotate the image 90 degrees.
//Start with a small 3x3 or 4x4
//Use a temp variable / placeholder
//Use a nested for loop
using System;

class Program
{

    // Function to rotate a square matrix by 90 degrees in clockwise direction
    static void RotateMatrix(int[][] mat)
    {
        int n = mat.Length;

        // Consider all cycles one by one
        for (int i = 0; i < n / 2; i++)
        {

            // Consider elements in group of 4 as P1, P2, P3 & P4 in current square
            for (int j = i; j < n - i - 1; j++)
            {
                //let's use example of 4x4
                // Swap elements in clockwise order
                int temp = mat[i][j]; //set P1 to temp                              [0,0] -> temp
                mat[i][j] = mat[n - 1 - j][i]; //move P4 to P1                      [3,0] -> [0,0]
                mat[n - 1 - j][i] = mat[n - 1 - i][n - 1 - j]; //Move P3 to P4      [3,3] -> [3,0]
                mat[n - 1 - i][n - 1 - j] = mat[j][n - 1 - i]; //Move P2 to P3      [0,3] -> [3,3]
                mat[j][n - 1 - i] = temp; //Move P1 to P2                           temp  -> [0,3]
            }
        }
    }

    public static void Main()
    {
        int[][] mat = {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12},
            new int[] {13, 14, 15, 16}
        };

        Console.WriteLine("Original Matrix:");

        // print original matrix
        foreach (int[]row in mat)
        {
            Console.WriteLine(string.Join(" ", row));
        }

        RotateMatrix(mat);

        Console.WriteLine("\nNew Matrix:");

        // Print the rotated matrix
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                Console.Write(mat[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}