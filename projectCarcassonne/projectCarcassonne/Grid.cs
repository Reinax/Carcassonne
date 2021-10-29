using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace projectCarcassonne
{
    public static class Grid
    {
        public static int row = 13;
        public static int col = 13;
        public static int[,] matrix = new int[row, col];
        public static int tileNumber = 0;
        public static int GlobalX;
        public static int GlobalY;

        public static void initializeBoard()
        {
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        GridSpot square = new GridSpot( i, j);
                        square.GridID = tileNumber++;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DrawBoard()
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        //Console.Write("  --------" + "\n" + "  |       |" + "\n" + "    " + i + "," + j + "\n" + "  |       |" + "\n" + "  --------- \n" );
                        GridSpot square = new GridSpot(i, j);
                        Console.Write(square.GridID + ": " + "(" + square.rowNum.ToString() + "," + square.colNum.ToString() + ")" + "   ");
                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static void RandomElement()
        {
            int rnd = new Random().Next(0, matrix.Length - 1);
            int row = matrix[rnd, 0];
            int col = matrix[rnd, 1];
            Console.WriteLine(row.ToString(), col.ToString());  
        }

        public static void AddTileRandomlyToGrid(Tile tileid)
        {
            Random r = new Random();
            var result  = matrix.GetValue(0, 0);
            int x = r.Next(0, 12); // for ints
            int y = r.Next(0, 12);

            matrix.SetValue(tileid.TileID, x, y);
            Console.WriteLine($"{ x },{ y } = {matrix.GetValue(x, y)}");
            CarcassoneMove.firstmove = false;
        }


        //fix this to make adding to the grid successful!
        public static void AddTileToGrid(Tile tileid, int x, int y)
        {
            Console.WriteLine("function called");
            matrix.SetValue(tileid.TileID, x, y);
            Console.WriteLine($"{ x },{ y } = {matrix.GetValue(x, y)}");
            Tile.RemoveTile(tileid);
        }
       
        //idea here is to check all tiles enum in grid and print the x y of the tiles the selected tile
        // can be placed against and what side it can be placed against.
        public static List<int> ListOfCoordinates = new List<int>();
        public static void InitializeTheBoard()
        {
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {

                    ListOfCoordinates.Add(x);
                    ListOfCoordinates.Add(y);
                    Console.WriteLine($"{x},{y}");

                }
            }

            
        }

        public static List<int> ListOfValidCoordinates = new List<int>();
        public static bool findValidCoordinates(Tile tile)
        {

            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    Console.WriteLine("Getting to this point");
                    if (matrix[x, y] != tile.TileID)
                    {
                        Console.WriteLine("x:" + x + "y:" + y);
                        Console.WriteLine("matrix:" + matrix[x, y]);
                        ListOfValidCoordinates.Add(x);
                        ListOfValidCoordinates.Add(y);
                        if ((Program.turn % 2) == 0)
                        {
                            Tile.TileCheckerRandom(tile, x, y);
                        }
                        else if ((Program.turn % 2) == 1)
                        {
                            Tile.TileCheckerRoad(tile, x, y);
                        }
                        Console.WriteLine($"{x},{y}");
                        Console.WriteLine("Test");
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return false;

        }


    }

}
