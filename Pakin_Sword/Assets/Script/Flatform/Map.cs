using System.Collections.Generic;

public class Map
{
    private static int LimitX = 0;
    private static int LimitY = 0;

    public static int limitX
    {
        get { return LimitX; }
    }
    public static int limitY
    {
        get { return LimitY; }
    }
    
    public List<Cell> data;

    public Map()
    {
        data = new List<Cell>();
    }
}