using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 狀態模式練習
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Work();
            work.Hour = 9;
            work.WriteProgress();
            work.Hour = 10;
            work.WriteProgress();
            work.Hour = 12;
            work.WriteProgress();
            work.Hour = 13;
            work.WriteProgress();
            work.Hour = 14;
            work.WriteProgress();
            work.Hour = 17;

            //work.WorkFinished = true;
            work.WorkFinished = false;
            work.WriteProgress();

            work.Hour = 19;
            work.WriteProgress();
            work.Hour = 20;
            work.WriteProgress();

            Console.ReadKey();
        }
    }
}
