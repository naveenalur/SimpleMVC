using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buiness.Infra.Command
{
    public abstract class CommandBase : ICommand
    {
        public bool Success { get; set; }
        public string SuccessMessage { get; set; }
        public List<string> SuccessMessages { get; set; } = new List<string>();
        public bool ShowSuccessMessages { get; set; } = true;
        public IEnumerable<ValidationResult> Errors { get; set; }
        public int UpdatedByProfileId { get; set; }
        public TimeZoneInfo UsersTimeZoneInfo { get; set; }
        public bool UseAuditing { get; set; } = true;
        public bool RedirectToUnexpectedErrorPageOnDbException { get; set; } = true;
        // public void LogException(Exception ex, string customMessage, IRemindTracDbContext _context) => ExceptionUtilities.LogException(ex, customMessage, _context);
        public bool IsSpanish => Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "es";
        public string DateFormat => IsSpanish ? "dd/MM/yyyy" : "MM/dd/yyyy";
        public string TimeFormat => IsSpanish ? "HH:mm" : "h:mm tt";
    }
}
