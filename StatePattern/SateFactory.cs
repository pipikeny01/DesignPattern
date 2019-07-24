namespace StatePattern
{
    public class StateFactory
    {
        public static WorkState Get上午工作狀態()
        {
            return  new 上午工作狀態();
        }

        public static WorkState Get中午工作狀態()
        {
            return  new 中午工作狀態();
        }

        public static WorkState Get下午工作狀態()
        {
            return new 下午工作狀態();
        }

        public static WorkState Get傍晚工作狀態()
        {
            return new 傍晚工作狀態();
        }

        public static WorkState Get晚上工作狀態()
        {
            return new 晚上工作狀態強制下班();
        }

        public static WorkState Get想睡覺狀態()
        {
            return new 想睡覺狀態();
        }

        public static WorkState Get強制下班()
        {
            return new 強制下班();
        }
    }
}