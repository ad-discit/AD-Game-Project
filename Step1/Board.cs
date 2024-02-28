using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awalé
{
    public class Board
    {
        public Row[] Rows { get; set; }

        public Board()
        {
            Rows = new Row[2]; // 2 rows 
            Rows[0] = new Row();
            Rows[1] = new Row();
        }

        // Example Methods
        public void SetupBoard()
        {
            // Initializes
        }

        public void DisplayBoard()
        {
            // displays the board's current state
        }
    }

}
