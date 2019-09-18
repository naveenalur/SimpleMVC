using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Buiness.Infra.Command
{
    public interface ICommand
    {
        bool Success { get; set; }
        string SuccessMessage { get; set; }
        List<string> SuccessMessages { get; set; }
        IEnumerable<ValidationResult> Errors { get; set; }
        int UpdatedByProfileId { get; set; }
        TimeZoneInfo UsersTimeZoneInfo { get; set; }
        bool UseAuditing { get; set; }
        bool RedirectToUnexpectedErrorPageOnDbException { get; set; }
        //  void LogException(Exception ex, string customMessage, SimpleCRUDContext  _context);
    }
}
