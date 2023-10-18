using System;
using System.Threading.Tasks;
using UnityEngine;

public class CharacterLoader
{
    private static string[] header { get; set;}

    public static string[] Header
    {
        get { return header; }
    }

    public static async Task<CharacterDataBase> Load( int id )
    {
        Debug.Log("it's Loading Character");
        var sheet = (await csvReader.LoadInRelative("CharacterSheet.csv")).Split(";");
        //인덱스 10번부터 시작, n 번째 줄의 마지막 인덱스 : 9*n + 10
        header = sheet[0].Split(",");
        
        CharacterDataBase result = new CharacterDataBase();
        var parseTarget = sheet[id + 1].Split(",");
        
        for (int i = 0; i < 9; i++)
        {
            result.Data[i] = Convert.ToInt32(parseTarget[i]);
        }

        result.Name = parseTarget[9];

        return result;
    }
}