using System;

public class Player : CharacterBase
{
    public override async void Create(int id)
    {
        Data =  await CharacterLoader.Load(0);
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