using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;

public class StageGameManager : MonoBehaviour
{
      private static Map _map;
      private static bool _isStarted = false; //스테이지가 실행된 후 실제로 게임이 시작 되었는지를 판별하는 변수 
      public static bool IsStarted => _isStarted;

       public PieceManager pieceManager;

       private void Awake()
       {
             pieceManager = new PieceManager();
       }

       private async void Start()
      {
            _map = await MapManager.LoadMapAsync("SampleMap.owlmap");
      }

      private void Update()
      {
            if (_isStarted)
            {
                  //실제 스테이지가 진행 중인 단계
                  //Debug.Log("the game is processing"); -- 작동

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
      
      public static void StartGame()
      {
            //스테이지가 진행되는 진입점
            
            Debug.Log("the Game has Started.");
            _isStarted = true;
      }
}