using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using Microsoft.SqlServer.Server;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBFactory factory = new DBFactory();
            //配合簡單工廠
            var db = factory.GetDB(DbServerType.Access);

            var userRepos = db.CreateUserRepos();

            userRepos.Insert(null);

            var departRepos = db.CreateDepartRepos();

            departRepos.Insert(null);

            var companyRepos = db.CreateCompanyRepos();

            var company = companyRepos.GetCompany();

            Console.ReadKey();
        }
    }

    internal enum DbServerType
    {
        SqlServer,
        Access
    }


    internal class Company
    {
        public string Name { set; get; }
    }

    internal class User
    {
        public string ID { set; get; }

        public string Name { set; get; }

    }

    internal class Department
    {
        internal string ID { set; get; }

        internal string Name { get; set; }
    }

}
