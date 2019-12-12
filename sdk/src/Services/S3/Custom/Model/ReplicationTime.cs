using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A container specifying the time when all objects and operations on objects are replicated. Must be specified together with a <code>Metrics</code> block. 
    /// </summary>
    public class ReplicationTime
    {
        private ReplicationTimeStatus status;
        private ReplicationTimeValue time;

        /// <summary>
        /// Specifies whether the replication time is enabled.
        /// </summary>
        public ReplicationTimeStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// A container specifying the time by which replication should complete for all objects and operations on objects.
        /// </summary>
        public ReplicationTimeValue Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        internal bool IsSetTime()
        {
            return this.time != null;
        }
    }
}
