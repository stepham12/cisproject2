using System;

//Stephanie Amo
//CIS 237
//Due: 10/01/2019

namespace cis237_assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a separate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {

            //Call mazeTraversal method
            mazeTraversal(maze, xStart,yStart);

        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// More than likely you will need to pass in at a minimum the current position
        /// in X and Y maze coordinates. EX: mazeTraversal(int currentX, int currentY)
        /// </summary>
        private Boolean mazeTraversal(char[,] maze, int currentX,int currentY)
        {

            bool success = false;

            //Mark the current spot as X
            maze[currentX, currentY] = 'X';
            PrintMaze(maze);

            //base case, where the edge of the array has been reached successfully
            if (currentX == 0 || currentY == 0 || currentX == (maze.GetLength(0) - 1) || currentY == (maze.GetLength(0) - 1))
            {
                Console.WriteLine("Maze is solved!!!");
                Console.WriteLine();
                success = true;
            }

            // Move down and recursively check if this leads to solution (x,y) -> (x,y+1)
            if (!success && maze[currentX, currentY + 1].ToString() == ".")
            {
                success = mazeTraversal(maze, currentX, currentY+1);
            }

            // Move left and recursively check if this leads to solution (x,y) -> (x-1,y)
            if (!success && maze[currentX - 1, currentY].ToString() == ".")
            {
                success = mazeTraversal(maze, currentX - 1, currentY);
            }

            // Move up and recursively check if this leads to solution (x,y) -> (x,y-1)
            if (!success && maze[currentX, currentY - 1].ToString() == ".")
            {
                success = mazeTraversal(maze, currentX, currentY - 1);
            }

            // Move right and recursively check if this leads to solution (x,y) -> (x+1,y)
            if (!success && maze[currentX + 1, currentY].ToString() == ".")
            {
                success = mazeTraversal(maze, currentX + 1, currentY);
            }

            //Mark as O if have to backtrack
            if (!success)
            {
                maze[currentX, currentY] = 'O';
                PrintMaze(maze);
            }

            return success;
        }

        private void PrintMaze(char[,] maze)
        {
            string printString = "";

            for (int x = 0;  x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(0); y++)
                {
                    printString += (maze[x,y] + " ");
                }
                printString += Environment.NewLine;
            }

            Console.WriteLine(printString);
        }
    }
}
