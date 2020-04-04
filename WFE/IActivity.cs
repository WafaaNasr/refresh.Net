namespace Exc_one_stopwatch.WFE
{
    public interface IActivity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public void Execute();
    }
}
