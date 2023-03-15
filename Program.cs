using System.Diagnostics;

string CreateString()
{
    string sample = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
    Random rnd = new Random();
    int length = 1000000000;
    char[] originalArr = new char[length];
    originalArr[0] = sample[rnd.Next(sample.Length)];
    for (int i = 1; i < length; i++)
    {
        originalArr[i] = rnd.Next(2) == 1 ? ' ' : sample[rnd.Next(sample.Length)];
    }
    return String.Join(String.Empty, originalArr);
}

void TrimRight(string input)
{
    int count = 0;

    for (int i = input.Length - 1; input[i].Equals(' ') && i >= 0; i--)
        count++;

    char[] charArr = new char[input.Length - count];

    for (int i = 0; i < charArr.Length; i++)
    {
        charArr[i] = input[i];
    }
    string output = String.Join(String.Empty, charArr);
    // Console.Write(output);
}
string txt = CreateString();
// Console.Write(txt);
// Console.WriteLine("|");

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

TrimRight(txt);
// Console.WriteLine("|");

stopwatch.Stop();

Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms.");