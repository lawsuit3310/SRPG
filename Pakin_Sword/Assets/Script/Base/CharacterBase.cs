public abstract class CharacterBase
{
    protected CharacterDataBase data;
    
    public string Name { get => data.Name;}

    internal int Coordinate = 1;
    
    public abstract void Create(int id);
    public abstract void Think();
    public abstract void Move();
}