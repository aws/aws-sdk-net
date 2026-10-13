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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary of information about a processing job.
    /// </summary>
    public partial class ProcessingJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the processing job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExitMessage. 
        /// <para>
        /// An optional string, up to one KB in size, that contains metadata from the processing
        /// container when the processing job exits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ExitMessage { get; set; }

        /// <summary>
        /// Checks to see if the ExitMessage property is set.
        /// </summary>
        internal bool IsSetExitMessage() => this.ExitMessage != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A string, up to one KB in size, that contains the reason a processing job failed,
        /// if it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that indicates the last time the processing job was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessingEndTime. 
        /// <para>
        /// The time at which the processing job completed.
        /// </para>
        /// </summary>
        public DateTime? ProcessingEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingEndTime property is set.
        /// </summary>
        internal bool IsSetProcessingEndTime() => this.ProcessingEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the processing job..
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ProcessingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobArn property is set.
        /// </summary>
        internal bool IsSetProcessingJobArn() => this.ProcessingJobArn != null;

        /// <summary>
        /// Gets and sets the property ProcessingJobName. 
        /// <para>
        /// The name of the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ProcessingJobName { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobName property is set.
        /// </summary>
        internal bool IsSetProcessingJobName() => this.ProcessingJobName != null;

        /// <summary>
        /// Gets and sets the property ProcessingJobStatus. 
        /// <para>
        /// The status of the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingJobStatus ProcessingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobStatus property is set.
        /// </summary>
        internal bool IsSetProcessingJobStatus() => this.ProcessingJobStatus != null;
    }
}
