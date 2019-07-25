using System;

namespace AbstractFactory.Repos
{
    internal class AccessUserRepos
        : IUserRepos
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access User 新增紀錄");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access User 查詢紀錄");

            return null;
        }
    }
}