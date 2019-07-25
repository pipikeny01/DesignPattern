using System;

namespace AbstractFactory.Repos
{
    internal class SqlServerDepartRepos : IDepartRepos
    {
        public void Insert(Department user)
        {
            Console.WriteLine("在Sql service Department 新增紀錄");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Sql Service Department 查詢紀錄");

            return null;
        }
    }
}