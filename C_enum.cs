using System;

namespace MyApplication
{
 enum  Direction {
    NORTH, 
    EAST, 
    SOUTH,
     WEST
     
     }

  
  class Program
  {

    static void Main(string[] args)
    {
        int y = 0 ,x=0,  speed= 1;
      Direction dir = Direction.NORTH;
      Console.WriteLine(dir);
      if (dir == Direction.NORTH) {
    y-= speed;
} else if (dir== Direction.EAST)
{
    x+= speed;    
} else if (dir == Direction.SOUTH) {
    y += speed;
} else if (dir == Direction.WEST) {
    x += speed;
}
    
}
    }
  }

