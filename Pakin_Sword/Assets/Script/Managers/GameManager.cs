using System.Linq;
using UnityEngine;
public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
      private static bool _isEditing = false;
      private static bool _isStarted = false; //스테이지가 실행된 후 실제로 게임이 시작 되었는지를 판별하는 변수 

      private static GameManager _instance = null;
      public static GameManager Instance => _instance;
      
      public static bool IsEditing => _isEditing;
      public static bool IsStarted => _isStarted;
      

      private void Awake()
      {
            _instance = _instance == null ? this : _instance;
            if(!_instance.Equals(this))
                  Destroy(this.gameObject);
            DontDestroyOnLoad(this.gameObject);
      }

      private void Start()
=======
      private static Map map;

      private async void Start()
>>>>>>> 64bc989241388a6abc1cd905227a86903791ff83
      {
            //Map.Create(10,10);
      }

      private void Update()
      {
            //throw new NotImplementedException();
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

      public static void EditCell(Cell target)
      {
            
      }
}