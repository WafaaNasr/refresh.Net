using System;

namespace Exc_one_stopwatch
{
    class DBCommand
    {
        public readonly DbConnection DbConnection;
        public readonly string Instruction;
        public DBCommand(DbConnection dbConnection, string Instruction)
        {
            if (dbConnection is null)
            {
                throw new ArgumentNullException(nameof(dbConnection));
            }

            if (string.IsNullOrEmpty(Instruction))
            {
                throw new ArgumentException("Instruction can't be null or empty", nameof(Instruction));
            }

            this.DbConnection = dbConnection;
            this.Instruction = Instruction;
        }
        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine($"Executing you instruction {Instruction}");
            //Console.WriteLine(@"Executing you instruction {0}",Instruction);
            DbConnection.CloseConnection();
        }
    }
}
