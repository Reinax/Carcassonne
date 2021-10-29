using System;
using System.Collections.Generic;
using System.Text;

namespace projectCarcassonne
{
    public class Tile
    {
        //Get and set values
        public int TileID { get; set; }
        public string TileName { get; set; }

        //Setting the directions of each tile
        public TileSection North { get; set; }
        public TileSection East { get; set; }
        public TileSection South { get; set; }
        public TileSection West { get; set; }
        public TileSection Center { get; set; }


        //boolean to road terminator.
        //check north west south east

        public Tile(int TileID, string TileName, TileSection North, TileSection East, TileSection South, TileSection West, TileSection Center)
        {
            this.TileID = TileID;
            this.TileName = TileName;
            this.North = North;
            this.East = East;
            this.South = South;
            this.West = West;
            this.Center = Center;
        }
        
        /// <summary>
        ///     Rotations for Tiles.
        /// </summary>

        public void RotateClockwise()
        {
            var north = North;
            var east = East;
            var south = South;
            var west = West;
            var center = Center;

            North = west;
            East = north;
            South = east;
            West = south;
            Center = center;
        }
        public void CounterClockWise()
        {
            var north = North;
            var east = East;
            var south = South;
            var west = West;
            var center = Center;

            North = east;
            West = north;
            South = west;
            East = south;
            Center = center;
        }

        public void FullRotation()
        {
            var north = North;
            var east = East;
            var south = South;
            var west = West;
            var center = Center;

            North = south;
            South = north;
            East = west;
            West = east;
            Center = center;

        }

        public static List<int> ListofTiles = new List<int>();
        public static List<int> tempXY = new List<int>();
        public static List<Tile> tiles = new List<Tile>();
        public static List<Tile> activeTiles = new List<Tile>();
        public static void LoadTiles()
        {
            //Simplfied version of tile implementaiton.
            tiles.Add(new Tile(1, "Chapel",TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Chapel));
            tiles.Add(new Tile(2, "Chapel", TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Chapel));
            tiles.Add(new Tile(3, "Chapel", TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Chapel));
            tiles.Add(new Tile(4, "Chapel", TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Chapel));
            tiles.Add(new Tile(5, "Chapel_Road", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Chapel));
            tiles.Add(new Tile(6, "Chapel_Road", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Chapel));
            tiles.Add(new Tile(7, "Town_Center", TileSection.Castle, TileSection.Castle, TileSection.Castle, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(8, "Town_Wall_Bottom",TileSection.Castle, TileSection.Castle,TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(9, "Town_Wall_Bottom", TileSection.Castle, TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(10, "Town_Wall_Bottom", TileSection.Castle, TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(11, "Town_Wall_Bottom", TileSection.Castle, TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(12, "Town_wall_Bottom_road", TileSection.Castle, TileSection.Castle, TileSection.Road, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(13, "Town_wall_Bottom_road", TileSection.Castle, TileSection.Castle, TileSection.Road, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(14, "Town_wall_Bottom_road", TileSection.Castle, TileSection.Castle, TileSection.Road, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(15, "Town_wall_TopLeft", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(16, "Town_wall_TopLeft", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(17, "Town_wall_TopLeft", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(18, "Town_wall_TopLeft", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(19, "Town_wall_TopLeft", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(20, "Town_wall_TopLeft_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(21, "Town_wall_TopLeft_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(22, "Town_wall_TopLeft_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(23, "Town_wall_TopLeft_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(24, "Town_wall_TopLeft_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(25, "Town_LeftRight_Field_TopBottom", TileSection.Grass, TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(26, "Town_LeftRight_Field_TopBottom", TileSection.Grass, TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(27, "Town_LeftRight_Field_TopBottom", TileSection.Grass, TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Castle));
            tiles.Add(new Tile(28, "Town_Left_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(29, "Town_Left_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Castle, TileSection.Grass));
            tiles.Add(new Tile(30, "Town_Bottom_Top", TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(31, "Town_Bottom_Top", TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(32, "Town_Bottom_Top", TileSection.Castle, TileSection.Grass, TileSection.Castle, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(33, "Town_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(34, "Town_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(35, "Town_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(36, "Town_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(37, "Town_Top", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(38, "Town_Top_Road_BottomLeft", TileSection.Castle, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(39, "Town_Top_Road_BottomLeft", TileSection.Castle, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(40, "Town_Top_Road_BottomLeft", TileSection.Castle, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(41, "Town_Top_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(42, "Town_Top_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(43, "Town_Top_Road_BottomRight", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Grass, TileSection.Grass));
            tiles.Add(new Tile(44, "Town_Top_TRoad", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(45, "Town_Top_TRoad", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(46, "Town_Top_TRoad", TileSection.Castle, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(47, "Town_Top_Road_Left_to_Right", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(48, "Town_Top_Road_Left_to_Right", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(49, "Town_Top_Road_Left_to_Right", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(50, "Town_Top_Road_Left_to_Right", TileSection.Castle, TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road));
            tiles.Add(new Tile(51, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(52, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(53, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(54, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(55, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(56, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(57, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(58, "Road_Bottom_to_top", TileSection.Road, TileSection.Grass, TileSection.Road, TileSection.Grass, TileSection.Road));
            tiles.Add(new Tile(59, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(60, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(61, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(62, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(63, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(64, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(65, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(66, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(67, "Road_L_Bottom_Left", TileSection.Grass, TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Grass));
            tiles.Add(new Tile(68, "Village_T_Road", TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Village));
            tiles.Add(new Tile(69, "Village_T_Road", TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Village));
            tiles.Add(new Tile(70, "Village_T_Road", TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Village));
            tiles.Add(new Tile(71, "Village_T_Road", TileSection.Grass, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Village));
            tiles.Add(new Tile(72, "Village_Cross_Road", TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Road, TileSection.Village));

            foreach (Tile i in tiles)
            {
                Console.WriteLine($"{i.TileID} {i.TileName}");
            }
        }

        //Random Tile Method
        private static Random random = new Random();
        public static Tile GetRandomTile()
        {
            int index = random.Next(0, tiles.Count);
            //Console.WriteLine(tiles[index].TileID);
            Tile result = tiles[index];
            return result;
        }

        //Remove Tile
        public static void RemoveTile(Tile tile)
        {
            if (tiles.Contains(tile))
            {
                tiles.Remove(tile);
            }
            else
            {
                Console.WriteLine("This tile cannot be removed. As it isn't in the list.");
            }
        }

        public static void AddActiveTile(Tile tile)
        {
            int counter = 0;
            ListofTiles.Add(counter++);
            ListofTiles.Add(tile.TileID);
            activeTiles.Add(tile);
            foreach(Tile i in activeTiles)
            {
                Console.WriteLine($"{i.TileName} | {i.TileID} ");
            }
        }

        public static List<int> TileCheckerRandom(Tile tile, int x, int y)
        {
            //Random random = new Random();
            //int pickRandom = random.Next(1, 4)
            //Takes tile and checks against active tile list and checks where it can be placed on grid.
            foreach(Tile Activetile in activeTiles)
            {
                if (!(activeTiles.Contains(tile)))
                {
                    //check where it can be placed.
                    if (tile.South == Activetile.North)
                    {
                        Console.WriteLine("South");
                        int southX, southY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.South);
                        //adds x and y to a list to be printed to user.
                        southX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2];
                        southY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1] + 1;
                        Grid.AddTileToGrid(tile, southX, southY);
                        tempXY.Add(southX);
                        tempXY.Add(southY);
                    }
                    else if(tile.West == Activetile.East)
                    {
                        Console.WriteLine("West");
                        int westX, westY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.West);
                        westX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2] - 1;
                        westY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1];
                        Grid.AddTileToGrid(tile, westX, westY);
                        tempXY.Add(westX);
                        tempXY.Add(westY);
                    }
                    else if(tile.North == Activetile.South)
                    {
                        Console.WriteLine("North");
                        int northX, northY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.North);
                        northX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2];
                        northY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1] - 1;
                        Grid.AddTileToGrid(tile, northX, northY);
                        tempXY.Add(northX);
                        tempXY.Add(northY);
                    }
                    else if(tile.East == Activetile.West)
                    {
                        Console.WriteLine("East");
                        int eastX, eastY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.East);
                        eastX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2] + 1;
                        eastY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1];
                        Grid.AddTileToGrid(tile, eastX, eastY);
                        tempXY.Add(eastX);
                        tempXY.Add(eastY);
                    }
                    else
                    {
                        //Discard and get a new tile.
                        Console.WriteLine("Tile can't be placed around any active tile and will be removed.");
                        RemoveTile(tile);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Tile is already in Active Tiles.");
                }
            }
            AddActiveTile(tile);
            if (tile.South == TileSection.Grass || tile.North == TileSection.Grass || tile.East == TileSection.Grass || tile.West == TileSection.Grass)
            {
                Program.playerOne.PlayerOneScore = Program.playerOne.PlayerOneScore + 2;
            }
            else if (tile.South == TileSection.Castle || tile.North == TileSection.Castle || tile.East == TileSection.Castle || tile.West == TileSection.Castle)
            {
                Program.playerOne.PlayerOneScore = Program.playerOne.PlayerOneScore + 4;
            }
            else if (tile.South == TileSection.Road || tile.North == TileSection.Road || tile.East == TileSection.Road || tile.West == TileSection.Road)
            {
                Program.playerOne.PlayerOneScore = Program.playerOne.PlayerOneScore + 2;
            }
            else if (tile.Center == TileSection.Chapel)
            {
                Program.playerOne.PlayerOneScore = Program.playerOne.PlayerOneScore + 1;
            }
            return tempXY;
        }


        //TileChecker for playertwo.
        public static List<int> TileCheckerRoad(Tile tile, int x, int y)
        {
            //Make similar to above but make to specify moves towards roads.

            foreach (Tile Activetile in activeTiles)
            {
                if (!(activeTiles.Contains(tile)))
                {
                    //Will Check through all sides for roads first before checking for the next available space.
                    if(tile.South == TileSection.Road && Activetile.North == TileSection.Road)
                    {
                        Console.WriteLine("South-Road");
                        int southX, southY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.South);
                        
                        //adds x and y to a list to be printed to user.
                        southX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2];
                        southY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1] + 1;
                        Grid.AddTileToGrid(tile, southX, southY);
                        tempXY.Add(southX);
                        tempXY.Add(southY);
                    }
                    else if(tile.West == TileSection.Road && Activetile.East == TileSection.Road)
                    {
                        Console.WriteLine("West - Road");
                        int westX, westY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.West);

                        westX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2] - 1;
                        westY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1];
                        Grid.AddTileToGrid(tile, westX, westY);
                        tempXY.Add(westX);
                        tempXY.Add(westY);
                    }
                    else if (tile.North == TileSection.Road && Activetile.South == TileSection.Road)
                    {
                        Console.WriteLine("North - Road");
                        int northX, northY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.North);

                        northX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2];
                        northY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1] - 1;
                        Grid.AddTileToGrid(tile, northX, northY);
                        tempXY.Add(northX);
                        tempXY.Add(northY);
                    }
                    else if (tile.East == TileSection.Road && Activetile.West == TileSection.Road)
                    {
                        Console.WriteLine("East - Road");
                        int eastX, eastY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.East);

                        eastX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2] + 1;
                        eastY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1];
                        Grid.AddTileToGrid(tile, eastX, eastY);
                        tempXY.Add(eastX);
                        tempXY.Add(eastY);
                    }
                    else if(tile.South == Activetile.North)
                    {
                        Console.WriteLine("South :)");
                        int southX, southY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.South);
                        //adds x and y to a list to be printed to user.

                        southX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2];
                        southY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1] + 1;
                        Grid.AddTileToGrid(tile, southX, southY);
                        tempXY.Add(southX);
                        tempXY.Add(southY);
                    }
                    else if (tile.West == Activetile.East)
                    {
                        Console.WriteLine("West :)");
                        int westX, westY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.West);

                        westX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2] - 1;
                        westY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1];
                        Grid.AddTileToGrid(tile, westX, westY);
                        tempXY.Add(westX);
                        tempXY.Add(westY);
                    }
                    else if (tile.North == Activetile.South)
                    {
                        Console.WriteLine("North :)");
                        int northX, northY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.North);

                        northX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2];
                        northY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1] - 1;
                        Grid.AddTileToGrid(tile, northX, northY);
                        tempXY.Add(northX);
                        tempXY.Add(northY);
                    }
                    else if (tile.East == Activetile.West)
                    {
                        Console.WriteLine("East :)");
                        int eastX, eastY;
                        Console.WriteLine("Tile can be placed around " + Activetile.TileName + " At " + tile.East);

                        eastX = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 2] + 1;
                        eastY = Grid.ListOfCoordinates[Grid.ListOfCoordinates.Count - 1];
                        Grid.AddTileToGrid(tile, eastX, eastY);
                        tempXY.Add(eastX);
                        tempXY.Add(eastY);
                    }
                    else
                    {
                        //Discard and get a new tile.
                        Console.WriteLine("Tile can't be placed around any active tile and will be removed.");
                        RemoveTile(tile);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Tile is already in Active Tiles.");
                }
            }
            AddActiveTile(tile);
            if (tile.South == TileSection.Grass || tile.North == TileSection.Grass || tile.East == TileSection.Grass || tile.West == TileSection.Grass)
            {
                Program.playerTwo.PlayerTwoScore = Program.playerTwo.PlayerTwoScore + 2;
            }
            else if (tile.South == TileSection.Castle || tile.North == TileSection.Castle || tile.East == TileSection.Castle || tile.West == TileSection.Castle)
            {
                Program.playerTwo.PlayerTwoScore = Program.playerTwo.PlayerTwoScore + 4;
            }
            else if (tile.South == TileSection.Road || tile.North == TileSection.Road || tile.East == TileSection.Road || tile.West == TileSection.Road)
            {
                Program.playerTwo.PlayerTwoScore = Program.playerTwo.PlayerTwoScore + 2;
            }
            else if (tile.Center == TileSection.Chapel)
            {
                Program.playerTwo.PlayerOneScore = Program.playerTwo.PlayerTwoScore + 1;
            }
            return tempXY;
        }

    }
    

    public enum TileSection
    {
        Chapel = 0,
        Castle = 1,
        Road = 2,
        Grass = 3,
        Village = 4
    }

}
