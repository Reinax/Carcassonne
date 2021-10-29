using System;
using System.Collections.Generic;
using System.Text;

namespace projectCarcassonne
{
    public class CarcassoneMove
    {

        //Get player two working and debug road checker and print scores at end of play.(simple version)
        public static bool firstmove = true;
        public static void RandomPlay()
        {
            if (firstmove)
            {
                var PlayTile = Tile.GetRandomTile();
                Console.WriteLine("Where would you like to place tile : " + PlayTile.TileName);
                Grid.InitializeTheBoard();
                Grid.AddTileRandomlyToGrid(PlayTile);
                Tile.RemoveTile(PlayTile);
                Tile.AddActiveTile(PlayTile);

            }
            else
            {
                var PlayTile = Tile.GetRandomTile();
                Grid.InitializeTheBoard();
                Console.WriteLine("Where would you like to place tile : " + PlayTile.TileName);
                Grid.findValidCoordinates(PlayTile);
            }

        }
        public static void RoadPlay()
        {
            var PlayTile = Tile.GetRandomTile();
            Grid.InitializeTheBoard();
            Console.WriteLine("Where would you like to place tile : " + PlayTile.TileName);
            //get options and choose any with road.
            Grid.findValidCoordinates(PlayTile);
        }

    }
}
