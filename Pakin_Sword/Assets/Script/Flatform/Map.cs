using System.Collections.Generic;

public class Map
{
    private int LimitX = 0;
    private int LimitY = 0;

    public int limitX
    {
        get { return LimitX; }
    }
    public int limitY
    {
        get { return LimitY; }
    }
    
    public List<Cell> data = new List<Cell>();
}