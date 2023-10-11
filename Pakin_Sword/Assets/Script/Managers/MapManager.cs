using System.IO;
using System.Threading.Tasks;
using System;
using System.Linq;
using UnityEngine;

public class MapManager
{
    private static Map _map;
    public static Map Map => _map ;
    public static Map LoadMap(string _fileName)
    {
        if (_map != null)
        {
            return _map;
        }
        
        var result = new Map();
        try
        {
<<<<<<< HEAD
            int lineHeight = 0;
            int lineWidth = 0;
=======
            Map result = new Map();
            // 
>>>>>>> 64bc989241388a6abc1cd905227a86903791ff83
            StreamReader sr = new StreamReader($"{Application.dataPath}/Maps/{_fileName} ");

            while (!sr.EndOfStream)
            {
                var row = sr.ReadLineAsync().Result.Split(' ');
<<<<<<< HEAD
                
                for (int i = 0; i < row.Length; i++)
                {
                    string target = "Normal";
                    switch (row[i][0])
                    {
                        case String.WOODEN_CELL:
                            target = "Wood";
                            break;
                        case String.STONE_CELL:
                            target = "Stone";
                            break;
                        
                        
                        //새로운 종류의 셀이 추가 되면 여기에서 처리 바람.
                        
                    }

                    var cellInstance = Resources.Load<GameObject>("Prefabs/Cell/" + target);
                    cellInstance = GameObject.Instantiate(cellInstance, StageManager.Instance.gameObject.transform, true);

                    var cellComponent = cellInstance.AddComponent<Cell>();
                    cellComponent.InitCell(i,lineHeight);

                    lineWidth = i;
                }
                lineHeight -= 1;
            }
            
            StageManager.Instance.gameObject.transform.position =
                new Vector3(lineWidth * 0.5f, 0, lineHeight * 0.5f) * -1;
=======

                foreach (var bit in row)
                {
                    switch (bit[0])
                    {
                        case '0':
                            break;
                    }
>>>>>>> 64bc989241388a6abc1cd905227a86903791ff83

                }
            }
            sr.Close();
            _map = result;
            
        }
        catch (Exception e)
        {
            Debug.LogError($"{e.Message}, {e.StackTrace}");
        }

        return result;
    }
}