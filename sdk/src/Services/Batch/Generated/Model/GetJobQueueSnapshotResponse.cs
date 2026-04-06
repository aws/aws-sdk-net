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
    /// This is the response object from the GetJobQueueSnapshot operation.
    /// </summary>
    public partial class GetJobQueueSnapshotResponse : AmazonWebServiceResponse
    {
        private FrontOfQueueDetail _frontOfQueue;
        private FrontOfQuotaSharesDetail _frontOfQuotaShares;
        private QueueSnapshotUtilizationDetail _queueUtilization;

        /// <summary>
        /// Gets and sets the property FrontOfQueue. 
        /// <para>
        /// The list of the first 100 <c>RUNNABLE</c> jobs in each job queue. For first-in-first-out
        /// (FIFO) job queues, jobs are ordered based on their submission time. For job queues
        /// with an attached fair-share scheduling (FSS) or quota-share policy, jobs are ordered
        /// based on their job priority and share usage.
        /// </para>
        /// </summary>
        public FrontOfQueueDetail FrontOfQueue
        {
            get { return this._frontOfQueue; }
            set { this._frontOfQueue = value; }
        }

        // Check to see if FrontOfQueue property is set
        internal bool IsSetFrontOfQueue()
        {
            return this._frontOfQueue != null;
        }

        /// <summary>
        /// Gets and sets the property FrontOfQuotaShares. 
        /// <para>
        /// The first <c>RUNNABLE</c> job in each quota share. Jobs are ordered based on their
        /// job priority and share usage.
        /// </para>
        /// </summary>
        public FrontOfQuotaSharesDetail FrontOfQuotaShares
        {
            get { return this._frontOfQuotaShares; }
            set { this._frontOfQuotaShares = value; }
        }

        // Check to see if FrontOfQuotaShares property is set
        internal bool IsSetFrontOfQuotaShares()
        {
            return this._frontOfQuotaShares != null;
        }

        /// <summary>
        /// Gets and sets the property QueueUtilization. 
        /// <para>
        /// The job queue's capacity utilization, including total usage and breakdown per given
        /// share.
        /// </para>
        /// </summary>
        public QueueSnapshotUtilizationDetail QueueUtilization
        {
            get { return this._queueUtilization; }
            set { this._queueUtilization = value; }
        }

        // Check to see if QueueUtilization property is set
        internal bool IsSetQueueUtilization()
        {
            return this._queueUtilization != null;
        }

    }
}