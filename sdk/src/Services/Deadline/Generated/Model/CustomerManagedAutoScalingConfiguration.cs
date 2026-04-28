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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
    /// The auto scaling configuration settings for a customer managed fleet.
    /// </summary>
    public partial class CustomerManagedAutoScalingConfiguration
    {
        private int? _scaleOutWorkersPerMinute;
        private int? _standbyWorkerCount;
        private int? _workerIdleDurationSeconds;

        /// <summary>
        /// Gets and sets the property ScaleOutWorkersPerMinute. 
        /// <para>
        /// The number of workers that can be added per minute to the fleet. The default is a
        /// service-defined value that balances efficiency with cost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? ScaleOutWorkersPerMinute
        {
            get { return this._scaleOutWorkersPerMinute; }
            set { this._scaleOutWorkersPerMinute = value; }
        }

        // Check to see if ScaleOutWorkersPerMinute property is set
        internal bool IsSetScaleOutWorkersPerMinute()
        {
            return this._scaleOutWorkersPerMinute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StandbyWorkerCount. 
        /// <para>
        /// The number of idle workers maintained and ready to process incoming tasks. The default
        /// is 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? StandbyWorkerCount
        {
            get { return this._standbyWorkerCount; }
            set { this._standbyWorkerCount = value; }
        }

        // Check to see if StandbyWorkerCount property is set
        internal bool IsSetStandbyWorkerCount()
        {
            return this._standbyWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkerIdleDurationSeconds. 
        /// <para>
        /// The number of seconds that a worker can remain idle before it is shut down. The default
        /// is 300 seconds (5 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? WorkerIdleDurationSeconds
        {
            get { return this._workerIdleDurationSeconds; }
            set { this._workerIdleDurationSeconds = value; }
        }

        // Check to see if WorkerIdleDurationSeconds property is set
        internal bool IsSetWorkerIdleDurationSeconds()
        {
            return this._workerIdleDurationSeconds.HasValue; 
        }

    }
}