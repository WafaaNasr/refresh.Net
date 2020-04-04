using System;

namespace Exc_one_stopwatch
{
    class DBCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;
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

           _dbConnection= dbConnection;
           _instruction= Instruction;
        }
        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine($"Executing you instruction {_instruction}");
            //Console.WriteLine(@"Executing you instruction {0}",Instruction);
            _dbConnection.CloseConnection();
        }
    }
}
