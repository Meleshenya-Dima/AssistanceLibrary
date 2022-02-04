using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AssistanceLibrary
{
    public class WriterAndReadFiles<T>
    {
        // Read files
        public static string ReadTextFile(string path)
        {
            using StreamReader streamReader = new(path);
            return streamReader.ReadToEnd();
        }
        public static List<T> ReadJsonFile(string path)
        {
            using StreamReader reader = new(path);
            return JsonSerializer.Deserialize<List<T>>(reader.ReadToEnd());
        }

        // Write to files
        public static void WriteToTextFile(string path, bool addRecord, T[] textToWrite)
        {
            using StreamWriter streamWriter = new(path, addRecord, System.Text.Encoding.Default);
            for (int i = 0; i < textToWrite.Length; i++)
                streamWriter.WriteLine(textToWrite[i]);
        }

        public static void WriteToTextFile(string path, bool addRecord, T textToWrite)
        {
            using StreamWriter streamWriter = new(path, addRecord, System.Text.Encoding.Default);
            streamWriter.WriteLine(textToWrite);
        }

        public static void WriteToTextFile(string path, bool addRecord, T[,] textToWrite)
        {
            using StreamWriter streamWriter = new(path, addRecord, System.Text.Encoding.Default);
            for (int i = 0; i < textToWrite.GetLength(0); i++)
                for (int j = 0; j < textToWrite.GetLength(1); j++)
                    streamWriter.WriteLine(textToWrite[i, j]);
        }

        public static void WriteToTextFile(string path, bool addRecord, List<T> textToWrite)
        {
            using StreamWriter streamWriter = new(path, addRecord, System.Text.Encoding.Default);
            for (int i = 0; i < textToWrite.Count; i++)
                streamWriter.WriteLine(textToWrite[i]);
        }

        public static void CreateJsonFile(string path, List<T> jsonObject) => File.WriteAllText(path + @"\JsonObjects.json", JsonSerializer.Serialize(jsonObject));

        public static void CreateJsonFile(string path, T[] jsonObject) => File.WriteAllText(path + @"\JsonObjects.json", JsonSerializer.Serialize(jsonObject));

        public static void CreateJsonFile(string path, T jsonObject) => File.WriteAllText(path + @"\JsonObject.json", JsonSerializer.Serialize(jsonObject));

    }
}
