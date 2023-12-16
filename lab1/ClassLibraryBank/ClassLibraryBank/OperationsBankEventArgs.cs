using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{
    public class OperationsBankEventArgs
    {

        public string Message { get; }
        public float Sum { get; }
        public OperationsBankEventArgs(string message, float sum)
        {
            Message = message;
            Sum = sum;
        }
        public float EquivalentUAN { get; set; }
        public float BalanceUsd { get; set; }
    }
}
      