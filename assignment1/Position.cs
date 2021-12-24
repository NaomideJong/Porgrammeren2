using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Position
    {
        public int row;
        public int column;

        public Position String2Position(string pos)
        {
            int column = pos[0] - 'a';
            int row = 8 - int.Parse(pos[1].ToString());

            if (row > 0 && column > 0 && row < 8 && column < 8)
            {
                this.row = row;
                this.column = column;
                return this;
            }
            else
            {
                throw new Exception($"invalid position {pos}");

            }
        }
    }
}
