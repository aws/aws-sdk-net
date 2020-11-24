using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    ///<para>A container specifying settings for configuring replication metrics and events.</para>
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
