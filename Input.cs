namespace Decomposing;
public class Input
{
    public List<List<(int, char)>> core;
    public Input()
    {
        core = [];
    }
    public void ReadDataLines(string path)
    {
        List<(int line, char character)> package = [];
        int lineIndex = 1;
        int remainder = 0;
        string auxLine;
        string auxPackage;
        int lastIndex;

        foreach (string line in File.ReadLines(path))
        {
            auxLine = line.Replace(" ", "# ") + "#";
            lastIndex = 0;

            for (int i = 4 - package.Count; i < auxLine.Length; i += 4)
            {                
                auxPackage = auxLine[lastIndex..i];
                
                foreach (char item in auxPackage) 
                {
                    package.Add((lineIndex, item));
                }

                core.Add(new List<(int, char)>(package));
                lastIndex = i;
                remainder = auxLine.Length - lastIndex;
                package.Clear();
            }

            if (remainder > 0)
            {
                auxPackage = auxLine[(auxLine.Length - remainder)..auxLine.Length];
                foreach (char item in auxPackage) package.Add((lineIndex, item));
            }

            lineIndex++;
        }
    }
}