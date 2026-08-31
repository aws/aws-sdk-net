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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the GetJobQueueSnapshot operation.
    /// </summary>
    public partial class GetJobQueueSnapshotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FrontOfQueue. 
        /// <para>
        /// The list of the first 100 <c>RUNNABLE</c> jobs in each job queue. For first-in-first-out
        /// (FIFO) job queues, jobs are ordered based on their submission time. For job queues
        /// with an attached fair-share scheduling (FSS) or quota-share policy, jobs are ordered
        /// based on their job priority and share usage.
        /// </para>
        /// </summary>
        public FrontOfQueueDetail FrontOfQueue { get; set; }

        /// <summary>
        /// Checks to see if the FrontOfQueue property is set.
        /// </summary>
        internal bool IsSetFrontOfQueue() => this.FrontOfQueue != null;

        /// <summary>
        /// Gets and sets the property FrontOfQuotaShares. 
        /// <para>
        /// The first <c>RUNNABLE</c> job in each quota share. Jobs are ordered based on their
        /// job priority and share usage.
        /// </para>
        /// </summary>
        public FrontOfQuotaSharesDetail FrontOfQuotaShares { get; set; }

        /// <summary>
        /// Checks to see if the FrontOfQuotaShares property is set.
        /// </summary>
        internal bool IsSetFrontOfQuotaShares() => this.FrontOfQuotaShares != null;

        /// <summary>
        /// Gets and sets the property QueueUtilization. 
        /// <para>
        /// The job queue's capacity utilization, including total usage and breakdown per given
        /// share.
        /// </para>
        /// </summary>
        public QueueSnapshotUtilizationDetail QueueUtilization { get; set; }

        /// <summary>
        /// Checks to see if the QueueUtilization property is set.
        /// </summary>
        internal bool IsSetQueueUtilization() => this.QueueUtilization != null;
    }
}
