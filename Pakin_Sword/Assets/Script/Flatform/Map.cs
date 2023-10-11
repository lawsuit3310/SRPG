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
    
<<<<<<< HEAD
    public List<Cell> data;

    public Map()
    {
        data = new List<Cell>();
    }
=======
    public List<Cell> data = new List<Cell>();
>>>>>>> 64bc989241388a6abc1cd905227a86903791ff83
}