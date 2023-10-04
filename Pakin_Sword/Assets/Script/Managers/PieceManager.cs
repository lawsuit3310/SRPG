//기물(유닛)을 관리 하는 클래스
using System;
using System.Collections.Generic;

[Serializable]

public class PieceManager
{
    internal Queue<CharacterBase> Allay;
    internal Queue<CharacterBase> Enemy; 

    public PieceManager()
    {
        Allay = new Queue<CharacterBase>();
        Enemy = new Queue<CharacterBase>();
    }

    public void AllayProcess()
    {
        for (int i = 0; i < Allay.Count; i++)
        {
            var worker = Allay.Dequeue();
            //작업 수행
            worker.Think();
            Allay.Enqueue(worker);
        }
    }
    
    public void EnemyProcess()
    {
        for (int i = 0; i < Enemy.Count; i++)
        {
            var worker = Enemy.Dequeue();
            //작업 수행
            worker.Think();
            Enemy.Enqueue(worker);
        }
    }
}