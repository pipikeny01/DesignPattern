using System;
using AbstractFactory.Repos;

namespace AbstractFactory.Factory
{
    internal class AccessFactory : IUserReposFactory
    {
        public IUserRepos CreateUserRepos()
        {
            return new AccessUserRepos();
        }

        public IDepartRepos CreateDepartRepos()
        {
            return new AccessDepartRepos();
        }

        public ICompanyRepos CreateCompanyRepos()
        {
            return new AccessCompanyRepos();
        }
    }

    internal class AccessCompanyRepos : ICompanyRepos
    {
        public Company GetCompany()
        {
            Console.WriteLine("Access 取得Company紀錄");
            return null;
        }
    }
}