using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHight;
        char sym;

        Random random = new Random( );

        public FoodCreator(int mapWidht, int mapHight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHight = mapHight;
            this.sym = sym;
        }

        public Point CreatorFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, sym);
        }
    }
}
