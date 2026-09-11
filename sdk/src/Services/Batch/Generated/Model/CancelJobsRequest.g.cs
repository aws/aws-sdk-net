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
    /// Container for the parameters to the CancelJobs operation. Cancels up to 50 jobs in
    /// an Batch job queue. This is a bulk version of <a>CancelJob</a>. Jobs that are in a
    /// <c>SUBMITTED</c>, <c>PENDING</c>, or <c>RUNNABLE</c> state are cancelled and the job
    /// status is updated to <c>FAILED</c>. <note> <para> A <c>PENDING</c> job is cancelled
    /// after all dependency jobs are completed. Therefore, it might take longer than expected
    /// to cancel a job in <c>PENDING</c> status. </para> <para> When you try to cancel an
    /// array parent job in <c>PENDING</c>, Batch attempts to cancel all child jobs. The array
    /// parent job is cancelled when all child jobs are completed. </para> </note> <para>
    /// Jobs that progressed to the <c>STARTING</c> or <c>RUNNING</c> state aren't cancelled.
    /// These jobs must be terminated with the <a>TerminateJob</a> or <a>TerminateJobs</a>
    /// operation. </para> <para> Batch reports the result for each job individually in the
    /// response. Jobs that were processed successfully are reported in the <c>successful</c>
    /// list. Jobs that encountered errors are reported in the <c>errors</c> list. The response
    /// returns an HTTP status code of <c>200</c> even when some jobs encountered errors,
    /// so check the <c>errors</c> list. Jobs that can't be found are treated as successfully
    /// processed. </para>
    /// </summary>
    public partial class CancelJobsRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property Jobs. 
        /// <para>
        /// An array of up to 50 Batch job IDs of the jobs to cancel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Jobs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Jobs property is set.
        /// </summary>
        internal bool IsSetJobs() => this.Jobs != null && (this.Jobs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message to attach to the job that explains the reason for cancelling it. This message
        /// is returned by future <a>DescribeJobs</a> operations on the job. It is also recorded
        /// in the Batch activity logs.
        /// </para>
        ///  
        /// <para>
        /// This parameter has a limit of 1024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
