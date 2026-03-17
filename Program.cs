using Decomposing;

string[] inputFile = File.ReadAllLines("//home//ArthurDSN//Projetos//DecomposingSystems//many_sentences.txt");

Input input = new();
input.StoreInCore(inputFile);

CircularShift circularShift = new();
circularShift.StoreWordsInPairs(input.Core, input.LineStarts, input.EndOfWord);