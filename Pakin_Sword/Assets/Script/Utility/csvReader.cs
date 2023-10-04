using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

//csv 파일을 읽어서 string으로 반환하는 클래스
//Pasing은 다른 곳에서
public static class csvReader
{
    private static FileStream fs;
    public static string Load(string Path)
    {
        string result = "";
        try
        {
            fs = File.OpenRead(Path);
            var sr = new StreamReader(fs);
            

            //Reading
            while (!sr.EndOfStream)
            {
                result += sr.ReadLine() + ";";
            }

            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            fs.Close();
        }
        return result;
    }

    public async static Task<string> LoadInRelative(string Path)
    {
        Thread.Sleep(1000);
        return Load(System.Environment.CurrentDirectory  + "\\Data\\" + Path);
    }
}