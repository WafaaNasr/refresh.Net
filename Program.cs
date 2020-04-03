using System;

namespace Exc_one_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestStopwatch();
            // TestStackoverflowPost();
            // TestDBConnection();
            var dBCommand = new DBCommand(
                new SqlConnection("helllo world"),
                "Instruction om 7amda"
            );
            var sqlCommand= dBCommand;
            sqlCommand.Execute();
        }

        private static void TestDBConnection()
        {
            var sqlConn = new SqlConnection("Hello World!");
            sqlConn.OpenConnection();
            sqlConn.CloseConnection();
            sqlConn.CloseConnection();
        }

        private static void TestStackoverflowPost()
        {
            var stackoverflowPost = new StackOverflowPost
            {
                Title = "Helloooooooo",
                Description = "Mohameeeed nayemmmmmmmmmmmmmm :'( "
            };

            stackoverflowPost.UpVote();
            stackoverflowPost.UpVote();
            stackoverflowPost.UpVote();
            stackoverflowPost.UpVote();
            stackoverflowPost.UpVote();


            Console.WriteLine(stackoverflowPost.Vote);
            stackoverflowPost.DownVote();
            Console.WriteLine(stackoverflowPost.Vote);

            var stackoverflowPost2 = new StackOverflowPost
            {
                Title = "Etfooooooo",
                Description = "Mohameeeed mesh3'l arfffffffff"
            };
            stackoverflowPost2.UpVote();
            stackoverflowPost2.UpVote();

            Console.WriteLine(stackoverflowPost2.Vote);
        }

        private static void TestStopwatch()
        {
            var stop = new StopWatch();
            stop.Start();
            Console.WriteLine("Hello World!");

            var x = 1;
            while (x < 100000000)
            {
                x++;
            }
            stop.Stop();
            Console.WriteLine(stop.Duration);

            stop.Start();
            stop.Stop();
            Console.WriteLine(stop.Duration);
        }
    }
}
