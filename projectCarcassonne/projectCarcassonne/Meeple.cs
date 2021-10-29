using System;
using System.Collections.Generic;
using System.Text;

namespace projectCarcassonne
{
    public class Meeple
    {
        public int MeepleID { get; set; }
        public string MeepleColour { get; set; }
 

        //Whenever making references to class.
        public Meeple(int MeepleID, string MeepleColour)
        {
            this.MeepleID = MeepleID;
            this.MeepleColour = MeepleColour;
        }

        //List of Meeples for references to play Class
        public static List<Meeple> meeples = new List<Meeple>();

        public static void LoadMeeples()
        {

            meeples.Add(new Meeple(1, "Red"));
            meeples.Add(new Meeple(2, "Red"));
            meeples.Add(new Meeple(3, "Red"));
            meeples.Add(new Meeple(4, "Red"));
            meeples.Add(new Meeple(5, "Red"));
            meeples.Add(new Meeple(6, "Red"));
            meeples.Add(new Meeple(7, "Blue"));
            meeples.Add(new Meeple(8, "Blue"));
            meeples.Add(new Meeple(9, "Blue"));
            meeples.Add(new Meeple(10, "Blue"));
            meeples.Add(new Meeple(11, "Blue"));
            meeples.Add(new Meeple(12, "Blue"));

            foreach (Meeple i in meeples)
            {
                Console.WriteLine($"{i.MeepleID} {i.MeepleColour}");
            }

        }

        public static Meeple GetMeepleRed() //red road
        {
            // if Player 2 Select Red Meeple else Select Blue Meeple for player2.
            var Item = meeples.Find(Meeple => Meeple.MeepleColour == "Red");
            Console.WriteLine($"{Item.MeepleID} {Item.MeepleColour}");
            return Item;
        }

        public static Meeple GetMeepleBlue() //blind blue
        {
            // if Player 1 Select Red Meeple else Select Blue Meeple for player2.
            var Item = meeples.Find(Meeple => Meeple.MeepleColour == "Blue");
            Console.WriteLine($"{Item.MeepleID} {Item.MeepleColour}");
            return Item;

        }

        public static void RemoveMeepleRed()
        {
            meeples.RemoveAt(GetMeepleRed().MeepleID);
        }

        public static void RemoveMeepleBlue()
        {
            meeples.RemoveAt(GetMeepleBlue().MeepleID);
        }


    }
}

//Limitations. results 