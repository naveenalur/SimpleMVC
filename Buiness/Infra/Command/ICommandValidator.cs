using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buiness.Infra.Command
{
    public interface ICommandValidator<in TCommand>
    {
        IEnumerable<ValidationResult> Validate(TCommand command);
    }
}
