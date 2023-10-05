using System.IO;
using System.Threading.Tasks;
using System;
using UnityEngine;

public class MapManager
{
    public static async Task<Map> LoadMapAsync(string _fileName)
    {
        try
        {
            Map result = new Map();
            // 
            StreamReader sr = new StreamReader($"{Application.dataPath}/Maps/{_fileName} ");
            while (!sr.EndOfStream)
            {
                var row = sr.ReadLineAsync().Result.Split(' ');

                foreach (var bit in row)
                {
                    switch (bit[0])
                    {
                        case '0':
                            break;
                    }

                }
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Debug.LogError($"Doesn't Exist File : {_fileName}");
        }
        return new Map();
    }
}