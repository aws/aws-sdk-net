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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The current job-run counts for a virtual cluster, reflecting how much of the configured
    /// scheduler capacity is in use.
    /// </summary>
    public partial class SchedulerStatus
    {
        /// <summary>
        /// Gets and sets the property CurrentConcurrentJobRuns. 
        /// <para>
        /// The number of job runs currently in the <c>RUNNING</c> state for the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentConcurrentJobRuns { get; set; }

        /// <summary>
        /// Checks to see if the CurrentConcurrentJobRuns property is set.
        /// </summary>
        internal bool IsSetCurrentConcurrentJobRuns() => this.CurrentConcurrentJobRuns.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentInQueueJobRuns. 
        /// <para>
        /// The number of job runs currently waiting in the queue (<c>PENDING</c> or <c>SUBMITTED</c>)
        /// for the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentInQueueJobRuns { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInQueueJobRuns property is set.
        /// </summary>
        internal bool IsSetCurrentInQueueJobRuns() => this.CurrentInQueueJobRuns.HasValue;
    }
}
