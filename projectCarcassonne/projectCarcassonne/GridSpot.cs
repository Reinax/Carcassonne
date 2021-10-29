using System;
using System.Collections.Generic;
using System.Text;

namespace projectCarcassonne
{
    public class GridSpot
    {
        public int rowNum;
        public int colNum;
        //Get and set values

        public int GridID { get; set; }

        public GridSpot(int row, int col)
        {
            rowNum = row;
            colNum = col;
        }
    }
}
