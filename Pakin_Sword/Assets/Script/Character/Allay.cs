using System;

public class Allay : CharacterBase
{
    public override async void Create(int id)
    {
        Data =  await CharacterLoader.Load(id);
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