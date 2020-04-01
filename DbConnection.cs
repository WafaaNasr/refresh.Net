using System;

namespace Exc_one_stopwatch
{
    abstract class DbConnection
    {
        public string ConnectionString { get; protected set; }
        protected TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(15);
        protected bool DbIsOpen { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
