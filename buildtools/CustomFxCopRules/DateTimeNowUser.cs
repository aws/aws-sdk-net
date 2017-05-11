using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFxCopRules
{
    public class DateTimeNowUser
    {
        public static readonly DateTime InitTime = DateTime.Now;
        public DateTime CreateTime {get;set;}

        public DateTimeNowUser()
        {
            CreateTime = DateTime.UtcNow;
        }
        public TimeSpan Since
        {
            get
            {
                return DateTime.UtcNow - CreateTime;
            }
        }
        public TimeSpan GetSince()
        {
            return DateTime.Now - InitTime;
        }
        public TimeSpan SinceMidnight
        {
            get
            {
                return InitTime - DateTime.Today;
            }
        }
    }
}
