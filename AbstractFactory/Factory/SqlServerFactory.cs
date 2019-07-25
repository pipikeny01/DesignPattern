using AbstractFactory.Repos;

namespace AbstractFactory.Factory
{
    internal class SqlServerFactory : IUserReposFactory
    {
        public IDepartRepos CreateDepartRepos()
        {
            return new SqlServerDepartRepos();
        }

        public ICompanyRepos CreateCompanyRepos()
        {
            return new SqlServerCompanyRepos();
        }

        public IUserRepos CreateUserRepos()
        {
            return new SqlServerUserRepos();
        }
    }
}