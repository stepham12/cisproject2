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
            // Do work needed to use mazeTraversal recursive call and solve the maze.
            int currentX = xStart;
            int currentY = yStart;

            //loop as long as exit is not found, which is when coordinates will be 
            //outside of the array 
            while(currentX < maze.GetLength(0) && currentY < maze.GetLength(1))
            {
                //Mark the current spot as X
                maze[currentX, currentY] = 'X';

                //Call mazeTraversal method to obtain next coordinates
                mazeTraversal(ref currentX,ref currentY);

                //Output the maze configuaration after each move
                PrintMaze(maze);

            }

        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// More than likely you will need to pass in at a minimum the current position
        /// in X and Y maze coordinates. EX: mazeTraversal(int currentX, int currentY)
        /// </summary>
        private void mazeTraversal(ref int currentX, ref int currentY)
        {
            // Implement maze traversal recursive call
            currentX++;
            currentY++;
        }

        private void PrintMaze(char[,] maze)
        {
            string printString = "";

            for (int x = 0;  x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(0); y++)
                {
                    printString += (maze[x,y] + " ");
                    //execute this code block as long as condition is satisfied 
                }
                printString += Environment.NewLine;
            }

            Console.WriteLine(printString);
        }
    }
}
