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
        /// Gets and sets the property Minutes. 
        /// <para>
        ///  Contains an integer specifying time in minutes. 
        /// </para>
        ///  
        /// <para>
        ///  Valid value: 15
        /// </para>
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
