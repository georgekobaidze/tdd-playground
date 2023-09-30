namespace FileHandler;

public static class Loader
{
    public static string LoadTextFile(string file)
    {
        if (file.Length < 10)
            throw new FileNotFoundException();

        return "The file was correctly loaded.";
    }
}