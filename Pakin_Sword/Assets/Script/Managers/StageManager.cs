using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;

public class StageManager : MonoBehaviour
{
      private static StageManager _instance;
      
      public PieceManager pieceManager;
      public static StageManager Instance => _instance;

      public Map Map;

      private void Awake()
      {
            _instance = this;
      }

      private void Start()
      {
            //Map.Create(10,10);
            Map = MapManager.LoadMap("SampleMap2.owlmap");
      }

      private void Update()
      {
            if (GameManager.IsStarted)
            {
                  //실제 스테이지가 진행 중인 단계
                  //Debug.Log("the game is processing"); -- 작동
                  //pieceManager.EnemyProcess();

                  if (pieceManager.Allay.Count == 0)
                  {
                        // 게임 오버
                  }

                  if (pieceManager.Enemy.Count == 0)
                  {
                        // 스테이지 클리어
                  }
                  
            }
            else
            {
                  //스테이지가 종료되었거나 스테이지가 시작되기 전 정비 하는 단계
            }
      }

      private void LateUpdate()
      {
            //throw new NotImplementedException();
      }
      

}