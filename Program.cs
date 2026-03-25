using Decomposing;

string[] inputFile = File.ReadAllLines("//home//ArthurDSN//Projetos//DecomposingSystems//many_sentences.txt");

Input input = new();
input.StoreInCore(inputFile);

CircularShift circularShift = new();
circularShift.StoreInPairs(input.Core, input.LineStarts, input.EndOfWord);

Alphabetizing alphabetizing = new();
alphabetizing.StoreSorted(input.Core, circularShift.CoreInPairs);

Output output = new();
output.OutputCircularShifts(input.Core, input.LineStarts, alphabetizing.sortedCoreInPairs);