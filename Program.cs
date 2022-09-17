var answer = File.ReadAllLines("answer.txt");
var output = File.ReadAllLines("output.txt");

List<string> answerVars = new List<string>();
List<string> outputVars = new List<string>();

foreach (var line in answer)
    foreach (var varrible in line.Split())
        answerVars.Add(varrible);

foreach (var line in output)
    foreach (var varrible in line.Split())
        outputVars.Add(varrible);

if (outputVars.Count != answerVars.Count)
    Environment.Exit(0xAA);

var length = outputVars.Count;

for (int i = 0; i < length; i++)
    if (outputVars[i] != answerVars[i])
        Environment.Exit(0xAB);
Environment.Exit(0xAC);