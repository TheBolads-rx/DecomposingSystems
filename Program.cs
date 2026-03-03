using Decomposing;

Input input = new();
input.ReadDataLines("//home//ArthurDSN//Projetos//DecomposingSystems//many_sentences.txt");

for (int i = 0; i < input.core.Count; i++)
{
    for (int j = 0; j < input.core[i].Count; j++)
    {
        WriteLine($"Line: {input.core[i][j].Item1}, Char: {input.core[i][j].Item2}");
    }
}