using System.Linq;

public class Cell
{
    private byte[] _position;
    public byte[] position
    {
        get { return position.Any() ? position : new byte [] {0,0};}
    }

    Cell(byte x, byte y)
    {
        _position = new byte[2] { x, y };
    }
}
