
namespace AbstractFactory.Repos
{
    internal interface IUserRepos 
    {
        void Insert(User user);

        User GetUser(int id);
    }

    internal interface IDepartRepos 
    {
        void Insert(Department user);

        Department GetDepartment(int id);
    }

    internal interface ICompanyRepos
    {
        Company GetCompany();
    }
}