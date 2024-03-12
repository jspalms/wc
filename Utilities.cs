public class Utilities
{
    public static long GetFileSize(Stream stream)
    {
        stream.Seek(0, SeekOrigin.Begin);
        var sr = new StreamReader(stream);
        try
        {
            int byteCount = 0;
            while (sr.Read() != -1)
            {
                byteCount++;
            }
            return byteCount;
        }
        catch
        {
            Console.WriteLine("The file could not be read:");
            throw;
        }
    }
    public static int GetFileLines(Stream stream)
    {
        stream.Seek(0, SeekOrigin.Begin);
        var sr = new StreamReader(stream);
        try
        {
            var lineCount = 0;

            {
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            return lineCount;
        }
        catch
        {
            Console.WriteLine("The file could not be read:");
            throw;
        }
    }
    public static int GetAllWords(Stream stream)
    {
        stream.Seek(0, SeekOrigin.Begin);
        var sr = new StreamReader(stream);
        try
        {
            char[] delims = { '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', ' ' };
            var readText = sr.ReadToEnd();
            string[] words = readText.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        catch
        {
            Console.WriteLine("The file could not be read:");
            throw;
        }
    }
    public static int GetAllCharacters(Stream stream)
    {
        stream.Seek(0, SeekOrigin.Begin);
        var sr = new StreamReader(stream);
        try
        {
            var readText = sr.ReadToEnd();
            return readText.Length;
        }
        catch
        {
            Console.WriteLine("The file could not be read:");
            throw;
        }
    }

}