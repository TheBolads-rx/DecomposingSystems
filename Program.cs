using Decomposing;

string[] inputFile = File.ReadAllLines("//home//ArthurDSN//Projetos//DecomposingSystems//many_sentences.txt");

Input input = new();
input.StoreInCore(inputFile);

CircularShift circularShift = new();
circularShift.StoreWordsInPairs(input.Core, input.LineStarts, input.EndOfWord);

// for (int i = 0; i < input.Core.Count; i++)
// {
//     if (input.LineStarts.Contains(i + 1) && i != 0)
//     {
//         WriteLine($"{new string(input.Core[i])}");
//     }
//     else
//     {
//         Write($"{new string(input.Core[i])}");
//     }    
// }