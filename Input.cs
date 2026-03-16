namespace Decomposing;
public class Input
{
    public Input()
    {
        Core = "";
        LineStarts = [];
    }
    public List<int> LineStarts;    
    public string Core;
    public readonly char EndOfWord = '\u0003';
    public void StoreInCore(string[] lines, int chunk = 4)
    {
        if (lines is null) return;       

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;           
            
            int count;
            int remainder = Core.Length % chunk;

            if (remainder != 0) 
            {
                count = (Core.Length - remainder) / chunk;
                count++;
            }
            else
            {
                count = Core.Length / chunk;                
            }

            LineStarts.Add(count);            
            
            string auxLine = line.Replace(" ", EndOfWord + " ") + EndOfWord + " ";

            for (int i = 0; i < auxLine.Length; i =+ (chunk + i)) 
            {
                int toIndex = i + chunk;

                if (toIndex > auxLine.Length) toIndex = auxLine.Length;                

                Core = string.Concat([Core, auxLine[i..toIndex]]);
            }
        }
    }
}