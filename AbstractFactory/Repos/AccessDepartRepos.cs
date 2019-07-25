using System;

namespace AbstractFactory.Repos
{
    internal class AccessDepartRepos : IDepartRepos
    {
        public void Insert(Department user)
        {
            Console.WriteLine("在 Access Department 新增紀錄");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在 Access Department 查詢紀錄");
            return null;
        }
    }
}