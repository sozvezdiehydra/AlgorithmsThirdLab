namespace AlgorithmsThirdLab;

public class FileReader
{
    public string[] FileRead()
    {
        string[] operations = File.ReadAllText("input.txt").Split(' ');
        return operations;
    }
}