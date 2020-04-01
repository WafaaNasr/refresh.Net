using System;

namespace Exc_one_stopwatch
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string dbconnection)
        {
            if (string.IsNullOrEmpty(dbconnection))
                throw new NullReferenceException("Connection string can not be null or empty");
            ConnectionString = dbconnection;

        }
        public override void CloseConnection()
        {
            if (!DbIsOpen) throw new Exception("Connection is already closed!");
            System.Console.WriteLine("Connection is closed");
            DbIsOpen = false;
        }

        public override void OpenConnection()
        {
            if (DbIsOpen) return;
            DbIsOpen = true;
            byte elapsed = 0;
            while (elapsed <= Timeout.Seconds)
            {
                elapsed++;
                if (!TryToConnect(elapsed))
                    continue;
                else
                    return;

            }
            throw new TimeoutException("Couldn't connect to Database");
        }
        private bool TryToConnect(byte elapsed)
        {

            if (elapsed <= 13)
            {
                elapsed++;
                return false;
            }
            System.Console.WriteLine("Connection is opened");
            return true;
        }
    }
}
