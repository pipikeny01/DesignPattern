using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    /// <summary>
    /// 運算類別工廠
    /// </summary>
    public class OperationFactory
    {
        public static IOperation GetOperation(string operation)
        {
            var dicOpration = GetOperationDictionary();

            if(!dicOpration.ContainsKey(operation))
                throw new Exception("Operation Error");

            return dicOpration[operation];

        }

        private static Dictionary<string, IOperation> GetOperationDictionary()
        {
            var dicOperation = new Dictionary<string, IOperation>();
            dicOperation.Add("+", new OperationAdd());
            dicOperation.Add("-", new OperationSub());
            dicOperation.Add("*", new OperationMul());
            dicOperation.Add("/", new OperationDiv());
            return dicOperation;
        }
    }

}