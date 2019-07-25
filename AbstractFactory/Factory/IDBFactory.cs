namespace AbstractFactory.Factory
{
    internal interface IDBFactory
    {
        IUserReposFactory GetDB(DbServerType dbServer);
    }
}