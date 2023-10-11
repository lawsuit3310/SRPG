[System.Serializable]
public class CharacterDataBase
{
    internal int[] Stats = new int[9];
    
    public int HitPoint => Stats[0]; //0
    public int Attack => Stats[1]; //1
    public int Magic => Stats[2]; //2
    public int Technical => Stats[3]; //3
    public int Speed => Stats[4]; //4
    public int Armor => Stats[5]; //5
    public int MagicResist => Stats[6]; //6
    public int Luck => Stats[7]; //7
    public int MovePoint => Stats[8]; //8

    public string Name = ""; //9

    public void print()
    {
        foreach (var cell in Stats)
        {
            //Console.WriteLine(cell);
        }
        //vConsole.WriteLine(Name);
    }

}