using AbstractFactory.Repos;

namespace AbstractFactory.Factory
{
    internal interface IUserReposFactory
    {
        IUserRepos CreateUserRepos();
        IDepartRepos CreateDepartRepos();
        ICompanyRepos CreateCompanyRepos();
    }
}