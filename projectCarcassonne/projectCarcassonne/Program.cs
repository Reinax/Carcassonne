using System;
using System.Collections.Generic;

namespace projectCarcassonne
{
    class Program
    {
        public static int turn = 0;
        public static int player1Wins;
        public static int player2Wins;
        public static Player playerOne = new Player(0, 0, 6);
        public static Player playerTwo = new Player(0, 0, 6);
        static void Main(string[] args)
        {

            int Timesplayed = 100;
            for (int i = 0; i < Timesplayed; i++)
            {
                Grid.initializeBoard();
                Grid.DrawBoard();
                Tile.LoadTiles();
                while (true)
                {

                    if ((turn % 2) == 0)
                    {
                        //player One play
                        //goes through play method
                        //updates tiles in play
                        if (Tile.tiles.Count == 0)
                        {
                            break;
                        }
                        else if (!(Tile.activeTiles.Contains(Tile.GetRandomTile())))
                        {
                            CarcassoneMove.RandomPlay();
                        }
                        turn++;
                    }
                    else if ((turn % 2) == 1)
                    {
                        //Player Two play
                        if (Tile.tiles.Count == 0)
                        {
                            break;
                        }
                        else if (!(Tile.activeTiles.Contains(Tile.GetRandomTile())))
                        {
                            CarcassoneMove.RoadPlay();
                        }
                        turn++;
                    }
                    else if (Tile.tiles.Count == 0)
                    {
                        break;
                    }
                    Console.WriteLine(Tile.tiles.Count);
                    Console.WriteLine("Player one Score: " + playerOne.PlayerOneScore);
                    Console.WriteLine("Player Two Score: " + playerTwo.PlayerTwoScore);
                }
                if (playerTwo.PlayerTwoScore < playerOne.PlayerOneScore)
                {
                    player1Wins++;
                    Console.WriteLine("Player One Wins");
                }
                else if (playerOne.PlayerOneScore < playerTwo.PlayerTwoScore)
                {
                    player2Wins++;
                    Console.WriteLine("Player Two Wins");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                playerOne.PlayerOneScore = 0;
                playerTwo.PlayerTwoScore = 0;
            }

            Console.WriteLine("Amount of Player 1 wins: " + player1Wins);
            Console.WriteLine("Amount of Player 2 wins: " + player2Wins);

            // Here will be where the scores are added to an array for storage
            //Player will Select Where they want the tile to be placed.
            //Second players turn.
            //player will Select where they want the tile to be placed.
            //End of turn and repeat until no tiles left.
        }


        //Where when a Tile is placed give a player a base Score added.
        //Once points are collected print and store them pref use method to store them. game by game basis


    }
}
