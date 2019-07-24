namespace SimpleFactory
{
    public class Calculator
    {
        public string Operation { get; set; }
        public int V1 { get; set; }
        public int V2 { get; set; }

        public int GetResult()
        {
            var operation = OperationFactory.GetOperation(this.Operation);
            operation.V1 = V1;
            operation.V2 = V2;
            return operation.GetResult();
        }
    }
}