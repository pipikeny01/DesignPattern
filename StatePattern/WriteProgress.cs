using System;

namespace StatePattern
{
    public abstract class WorkState
    {
        public abstract void WriteProgress(Work work);
    }

    public class 上午工作狀態 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"當前時間:{work.Hour} 上午工作,精神百倍");
            }
            else
            {
                work.SetWorkState(StateFactory.Get中午工作狀態());
                work.WriteProgress();
            }
        }
    }

    public class 中午工作狀態 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"當前時間:{work.Hour} 餓了,午飯;覺得睏,午睡");
            }
            else
            {
                work.SetWorkState(StateFactory.Get下午工作狀態());
                work.WriteProgress();
            }
        }
    }

    public class 下午工作狀態 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine($"當前時間:{work.Hour} 下午狀態還不錯,繼續努力");
            }
            else
            {
                work.SetWorkState(StateFactory.Get傍晚工作狀態());
                work.WriteProgress();
            }
        }
    }

    public class 傍晚工作狀態 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            if (work.WorkFinished)
            {
                Console.WriteLine($"當前時間:{work.Hour} 下班回家");
            }
            else
            {
                work.SetWorkState(StateFactory.Get晚上工作狀態());
                work.WriteProgress();
            }

        }
    }

    public class 晚上工作狀態 : WorkState
    {
        public override void WriteProgress(Work work)
        {

            if (work.Hour < 21)
            {
                Console.WriteLine($"當前時間:{work.Hour} 加班喔,疲累至極");
            }
            else
            {
                work.SetWorkState(StateFactory.Get想睡覺狀態());
                work.WriteProgress();
            }

        }
    }

    public class 晚上工作狀態強制下班 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            if (work.Hour < 20)
            {
                Console.WriteLine($"當前時間:{work.Hour} 加班喔,疲累至極");
            }
            else
            {
                work.SetWorkState(StateFactory.Get強制下班());
                work.WriteProgress();
            }

        }
    }


    public class 強制下班 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            Console.WriteLine($"當前時間:{work.Hour} 強制下班");

        }
    }

    public class 想睡覺狀態 : WorkState
    {
        public override void WriteProgress(Work work)
        {
            Console.WriteLine($"當前時間:{work.Hour} 不行了,睡著了");
        }
    }


    public class Work
    {
        public bool WorkFinished { get; set; } = false;

        public int Hour { get; set; }

        public WorkState CurrentWorkState { get; set; }

        public Work()
        {
            CurrentWorkState = StateFactory.Get上午工作狀態();
        }

        public void WriteProgress()
        {
            CurrentWorkState.WriteProgress(this);
        }

        public void SetWorkState(WorkState workState)
        {
            this.CurrentWorkState = workState;
        }

    }

}