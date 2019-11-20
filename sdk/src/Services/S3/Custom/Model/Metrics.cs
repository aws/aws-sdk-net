using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A container specifying replication metrics-related information, including whether 
    /// emitting metrics and Amazon S3 events for replication are enabled. In addition, contains 
    /// configurations related to specific metrics or events. Must be specified together with a 
    /// <code>ReplicationTime</code> block.
    /// </summary>
    public class Metrics
    {
        private MetricsStatus status;
        private ReplicationTimeValue eventThreshold;

        /// <summary>
        /// Specifies whether the replication metrics are enabled.
        /// </summary>
        public MetricsStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// A container specifying the time threshold for emitting the 
        /// <code>s3:Replication:OperationMissedThreshold</code> event.
        /// </summary>
        public ReplicationTimeValue EventThreshold
        {
            get { return this.eventThreshold; }
            set { this.eventThreshold = value; }
        }

        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        internal bool IsSetEventThreshold()
        {
            return this.eventThreshold != null;
        }
    }
}
