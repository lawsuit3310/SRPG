using System;

public class Allay : CharacterBase
{
    public override async void Create(int id)
    {
        data =  await CharacterLoader.Load(id);
        Coordinate = 10;
    }

    public override void Think()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}