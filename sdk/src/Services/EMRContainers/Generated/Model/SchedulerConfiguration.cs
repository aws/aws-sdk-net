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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
    /// The scheduler configuration for a virtual cluster on Amazon EMR on EKS. It controls
    /// how many job runs can run concurrently and how many can wait in the queue. When not
    /// set, no concurrency or queue limits are applied.
    /// </summary>
    public partial class SchedulerConfiguration
    {
        private int? _maxConcurrentJobRuns;
        private int? _maxInQueueJobRuns;

        /// <summary>
        /// Gets and sets the property MaxConcurrentJobRuns. 
        /// <para>
        /// The maximum number of job runs that can be in the <c>RUNNING</c> state at any time
        /// for the virtual cluster. As running slots free up, queued job runs start automatically.
        /// If you omit this field, the service applies no concurrency limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxConcurrentJobRuns
        {
            get { return this._maxConcurrentJobRuns; }
            set { this._maxConcurrentJobRuns = value; }
        }

        // Check to see if MaxConcurrentJobRuns property is set
        internal bool IsSetMaxConcurrentJobRuns()
        {
            return this._maxConcurrentJobRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxInQueueJobRuns. 
        /// <para>
        /// The maximum number of job runs that can be in the <c>PENDING</c> or <c>SUBMITTED</c>
        /// state at any time for the virtual cluster. When the queue is full, the service rejects
        /// <c>StartJobRun</c> requests with a <c>ValidationException</c>. If you omit this field,
        /// the service applies no queue-depth limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=10000)]
        public int? MaxInQueueJobRuns
        {
            get { return this._maxInQueueJobRuns; }
            set { this._maxInQueueJobRuns = value; }
        }

        // Check to see if MaxInQueueJobRuns property is set
        internal bool IsSetMaxInQueueJobRuns()
        {
            return this._maxInQueueJobRuns.HasValue; 
        }

    }
}