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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The auto scaling configuration settings for a service managed EC2 fleet.
    /// </summary>
    public partial class ServiceManagedEc2AutoScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property ScaleOutWorkersPerMinute. 
        /// <para>
        /// The number of workers that can be added per minute to the fleet. The default is 10
        /// workers per minute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? ScaleOutWorkersPerMinute { get; set; }

        /// <summary>
        /// Checks to see if the ScaleOutWorkersPerMinute property is set.
        /// </summary>
        internal bool IsSetScaleOutWorkersPerMinute() => this.ScaleOutWorkersPerMinute.HasValue;

        /// <summary>
        /// Gets and sets the property StandbyWorkerCount. 
        /// <para>
        /// The number of idle workers maintained and ready to process incoming tasks. The default
        /// is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? StandbyWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the StandbyWorkerCount property is set.
        /// </summary>
        internal bool IsSetStandbyWorkerCount() => this.StandbyWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerIdleDurationSeconds. 
        /// <para>
        /// The number of seconds that a worker can remain idle before it is shut down. The default
        /// is 300 seconds (5 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 86400)]
        public int? WorkerIdleDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the WorkerIdleDurationSeconds property is set.
        /// </summary>
        internal bool IsSetWorkerIdleDurationSeconds() => this.WorkerIdleDurationSeconds.HasValue;
    }
}
