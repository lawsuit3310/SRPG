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
            StreamReader sr = new StreamReader($"{Application.dataPath}/Maps/{_fileName} ");
            while (!sr.EndOfStream)
            {
                var row = sr.ReadLine();
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