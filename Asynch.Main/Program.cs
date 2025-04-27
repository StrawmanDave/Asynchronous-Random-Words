Console.WriteLine("Enter a word to randomly regenerate.");
string? input = Console.ReadLine();

DateTime start = DateTime.Now;
int attempts =  await RandomlyRecreateAsync(input);
Console.WriteLine(attempts);
TimeSpan TimeTooken = DateTime.Now - start;
Console.WriteLine($"It took this {TimeTooken} much time to regenerate the word");

Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() => RandomlyRecreateStrings(word));
}


int RandomlyRecreateStrings(string word)
{
    if(word == null) return 0;
    Random random= new Random();
    int attempts = 0;
    string NewString;
    do
    {
        attempts ++;
        NewString = "";
        for(int i = 0; i < word.Length; i++)
        {
            NewString += (char)('a' + random.Next(26));
        }
    }while(NewString != word);
    return attempts;
}