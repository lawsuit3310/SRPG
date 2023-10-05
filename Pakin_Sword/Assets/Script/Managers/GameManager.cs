using System.Linq;
using UnityEngine;
public class GameManager : MonoBehaviour
{
      private static Map map;

      private async void Start()
      {
            //Map.Create(10,10);
            map = await MapManager.LoadMapAsync("SampleMap.owlmap");
      }

      private void Update()
      {
            //throw new NotImplementedException();
      }

      private void LateUpdate()
      {
            //throw new NotImplementedException();
      }
}