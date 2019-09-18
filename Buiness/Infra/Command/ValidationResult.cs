using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buiness.Infra.Command
{
    public class ValidationResult
    {
        public ValidationResult(string error)
        {
            Member = "";
            Error = error;
        }

        public ValidationResult(string member, string error)
        {
            Member = member;
            Error = error;
        }

        public string Member { get; private set; }
        public string Error { get; private set; }
    }
}
