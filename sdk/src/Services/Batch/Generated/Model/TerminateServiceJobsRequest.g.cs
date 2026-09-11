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
    /// Container for the parameters to the TerminateServiceJobs operation. Terminates up
    /// to 50 service jobs in a job queue. This is a bulk version of <a>TerminateServiceJob</a>.
    /// <para> Batch reports the result for each service job individually in the response.
    /// Service jobs that were processed successfully are reported in the <c>successful</c>
    /// list. Service jobs that encountered errors are reported in the <c>errors</c> list.
    /// The response returns an HTTP status code of <c>200</c> even when some service jobs
    /// encountered errors, so check the <c>errors</c> list. Service jobs that can't be found
    /// are treated as successfully processed. </para>
    /// </summary>
    public partial class TerminateServiceJobsRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property Jobs. 
        /// <para>
        /// An array of up to 50 service job IDs of the service jobs to terminate.
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
        /// A message to attach to the service job that explains the reason for terminating it.
        /// This message is returned by <c>DescribeServiceJob</c> operations on the service job.
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
