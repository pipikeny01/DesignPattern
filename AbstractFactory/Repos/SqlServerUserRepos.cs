using System;

namespace AbstractFactory.Repos
{
    internal class SqlServerUserRepos : IUserRepos
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Sql service User 新增紀錄");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Sql Service User 查詢紀錄");

            return null;
        }
    }
}