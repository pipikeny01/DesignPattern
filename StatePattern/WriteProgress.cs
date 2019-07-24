using System;

namespace StatePattern
{
    internal class Work
    {
        public bool WorkFinished { get; set; } = false;

        public int Hour { get; set; }

        public void WriteProgress()
        {
            if (Hour < 12)
            {
                Console.WriteLine($"當前時間:{Hour} 上午工作,精神百倍");
            }
            else if (Hour < 13)
            {
                Console.WriteLine($"當前時間:{Hour} 餓了,午飯;覺得睏,午睡");
            }
            else if (Hour < 17)
            {
                Console.WriteLine($"當前時間:{Hour} 下午狀態還不錯,繼續努力");
            }
            else
            {
                if (WorkFinished)
                    Console.WriteLine($"當前時間:{Hour} 下班回家");
                else
                {
                    if (Hour < 21)
                    {
                        Console.WriteLine($"當前時間:{Hour} 加班喔,疲累至極");
                    }
                    else
                    {
                        Console.WriteLine($"當前時間:{Hour} 不行了,睡著了");
                    }
                }
            }
        }
    }
}