using System;

namespace SimpleFactory
{
    public interface IOperation
    {
        int V1 { get; set; }
        int V2 { get; set; }
        int GetResult();
    }

    public abstract class Operation : IOperation
    {
        public int V1 { get; set; }
        public int V2 { get; set; }

        public abstract int GetResult();
    }

    public class OperationAdd : Operation
    {

        public override int GetResult()
        {
            return V1 + V2;
        }
    }

    public class OperationSub : Operation
    {
        public override int GetResult()
        {
            return this.V1 - this.V2;
        }
    }


    public class OperationMul : Operation
    {
        public override int GetResult()
        {
            return this.V1 * this.V2;
        }
    }

    public class OperationDiv : Operation
    {
        public override int GetResult()
        {
            if(V1 <= 0 )
                throw  new Exception("V1 應該大於0");

            return this.V1 / this.V2;
        }
    }

}