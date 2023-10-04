public class CharacterDataBase
{
 
    internal int[] Data = new int[9];
    
    public int HitPoint => Data[0]; //0
    public int Attack => Data[1]; //1
    public int Magic => Data[2]; //2
    public int Technical => Data[3]; //3
    public int Speed => Data[4]; //4
    public int Armor => Data[5]; //5
    public int MagicResist => Data[6]; //6
    public int Luck => Data[7]; //7
    public int MovePoint => Data[8]; //8

    public string Name = ""; //9

    public void print()
    {
        foreach (var cell in Data)
        {
            //Console.WriteLine(cell);
        }
        //vConsole.WriteLine(Name);
    }

}