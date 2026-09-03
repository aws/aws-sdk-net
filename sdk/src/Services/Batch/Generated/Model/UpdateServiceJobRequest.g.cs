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
    /// Container for the parameters to the UpdateServiceJob operation. Updates the priority
    /// of a specified service job in an Batch job queue.
    /// </summary>
    public partial class UpdateServiceJobRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The Batch job ID of the job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority for the job. This only affects jobs in job queues with a quota-share
        /// or fair-share scheduling policy. Jobs with a higher scheduling priority are scheduled
        /// before jobs with a lower scheduling priority within a share.
        /// </para>
        ///  
        /// <para>
        /// The minimum supported value is 0 and the maximum supported value is 9999.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SchedulingPriority { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPriority property is set.
        /// </summary>
        internal bool IsSetSchedulingPriority() => this.SchedulingPriority.HasValue;
    }
}
