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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the GetJobQueueSnapshot operation.
    /// Provides a snapshot of job queue state, including ordering of <c>RUNNABLE</c> jobs,
    /// as well as capacity utilization for already dispatched jobs. The first 100 <c>RUNNABLE</c>
    /// jobs in the job queue are listed in order of dispatch. For job queues with an attached
    /// quota-share policy, the first <c>RUNNABLE</c> job in each quota share is also listed.
    /// Capacity utilization for the job queue is provided, as well as break downs by share
    /// for job queues with attached fair-share or quota-share scheduling policies.
    /// </summary>
    public partial class GetJobQueueSnapshotRequest : AmazonBatchRequest
    {
        private string _jobQueue;

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The job queue’s name or full queue Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

    }
}