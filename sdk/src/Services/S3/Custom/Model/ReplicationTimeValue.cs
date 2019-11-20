using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A container specifying the time value.
    /// </summary>
    public class ReplicationTimeValue
    {
        private int? minutes;

        /// <summary>
        /// Contains an integer specifying time in minutes.
        /// </summary>
        public int Minutes
        {
            get { return this.minutes ?? default(int); }
            set { this.minutes = value; }
        }

        internal bool IsSetMinutes()
        {
            return this.minutes.HasValue;
        }
    }
}
