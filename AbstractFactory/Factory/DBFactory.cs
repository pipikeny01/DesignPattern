using System;

namespace AbstractFactory.Factory
{
    internal class DBFactory : IDBFactory
    {
        public IUserReposFactory GetDB(DbServerType dbServer)
        {
            switch (dbServer)
            {
                case DbServerType.SqlServer:        
                    return  new SqlServerFactory();
                case DbServerType.Access:
                    return new AccessFactory();
                default:
                    throw new ArgumentOutOfRangeException(nameof(dbServer), dbServer, null);
            }
        }
    }
}