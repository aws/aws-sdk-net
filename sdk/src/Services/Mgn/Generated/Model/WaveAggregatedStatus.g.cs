/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Wave aggregated status.
    /// </summary>
    public partial class WaveAggregatedStatus
    {
        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Wave aggregated status health status.
        /// </para>
        /// </summary>
        public WaveHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// Wave aggregated status last update dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string LastUpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateDateTime() => this.LastUpdateDateTime != null;

        /// <summary>
        /// Gets and sets the property ProgressStatus. 
        /// <para>
        /// Wave aggregated status progress status.
        /// </para>
        /// </summary>
        public WaveProgressStatus ProgressStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProgressStatus property is set.
        /// </summary>
        internal bool IsSetProgressStatus() => this.ProgressStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationStartedDateTime. 
        /// <para>
        /// DateTime marking when the first source server in the wave started replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string ReplicationStartedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStartedDateTime property is set.
        /// </summary>
        internal bool IsSetReplicationStartedDateTime() => this.ReplicationStartedDateTime != null;

        /// <summary>
        /// Gets and sets the property TotalApplications. 
        /// <para>
        /// Wave aggregated status total applications amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalApplications { get; set; }

        /// <summary>
        /// Checks to see if the TotalApplications property is set.
        /// </summary>
        internal bool IsSetTotalApplications() => this.TotalApplications.HasValue;
    }
}
