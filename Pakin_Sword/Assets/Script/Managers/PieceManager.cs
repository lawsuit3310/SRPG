//기물(유닛)을 관리 하는 클래스
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PieceManager
{
    private List<CharacterBase> _playable;
    private Queue<CharacterBase> _allay;
    private Queue<CharacterBase> _enemy;

    public List<CharacterBase> Playable
    {
        get { return _playable; }
    }
    public Queue<CharacterBase> Allay
    {
        get { return _allay; }
    }
    public Queue<CharacterBase> Enemy
    {
        get { return _enemy; }
    }

    public PieceManager()
    {
        _allay = new Queue<CharacterBase>();
        _enemy = new Queue<CharacterBase>();
        SetUp();
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
    private async void SetUp()
    {
        Task allayProcess = new Task(() =>
        {
            foreach (var allay in GameObject.FindGameObjectsWithTag("Allay"))
            {
                try
                {
                    Allay.Enqueue(allay.GetComponent<CharacterBase>());
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }

            }
        });
        Task enemyProcess = new Task(() =>
        {
            foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                try
                {
                    Enemy.Enqueue(enemy.GetComponent<CharacterBase>());
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            
            }
        });
        await allayProcess;
        await enemyProcess;
    }

}