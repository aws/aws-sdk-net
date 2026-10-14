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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// A truncated version of the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_BatchInferenceJob.html">BatchInferenceJob</a>.
    /// The <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListBatchInferenceJobs.html">ListBatchInferenceJobs</a>
    /// operation returns a list of batch inference job summaries.
    /// </summary>
    public partial class BatchInferenceJobSummary
    {
        /// <summary>
        /// Gets and sets the property BatchInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string BatchInferenceJobArn { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobArn property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobArn() => this.BatchInferenceJobArn != null;

        /// <summary>
        /// Gets and sets the property BatchInferenceJobMode. 
        /// <para>
        /// The job's mode.
        /// </para>
        /// </summary>
        public BatchInferenceJobMode BatchInferenceJobMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchInferenceJobMode property is set.
        /// </summary>
        internal bool IsSetBatchInferenceJobMode() => this.BatchInferenceJobMode != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The time at which the batch inference job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the batch inference job failed, the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The time at which the batch inference job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The ARN of the solution version used by the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SolutionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionVersionArn property is set.
        /// </summary>
        internal bool IsSetSolutionVersionArn() => this.SolutionVersionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch inference job. The status is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN PROGRESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
