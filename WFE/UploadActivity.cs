using Exc_one_stopwatch.WFE;

class UploadActivity : IActivity
{
    public string Name { get; set; }
    public string Value { get; set; }

    public void Execute()
    {
       System.Console.WriteLine("Executing activity upload video");
    }
}