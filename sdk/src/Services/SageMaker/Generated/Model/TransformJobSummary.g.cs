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
    /// Provides a summary of a transform job. Multiple <c>TransformJobSummary</c> objects
    /// are returned as a list after in response to a <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListTransformJobs.html">ListTransformJobs</a>
    /// call.
    /// </summary>
    public partial class TransformJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the transform Job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the transform job failed, the reason it failed.
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
        /// Indicates when the transform job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property TransformEndTime. 
        /// <para>
        /// Indicates when the transform job ends on compute instances. For successful jobs and
        /// stopped jobs, this is the exact time recorded after the results are uploaded. For
        /// failed jobs, this is when Amazon SageMaker detected that the job failed.
        /// </para>
        /// </summary>
        public DateTime? TransformEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TransformEndTime property is set.
        /// </summary>
        internal bool IsSetTransformEndTime() => this.TransformEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TransformJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TransformJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobArn property is set.
        /// </summary>
        internal bool IsSetTransformJobArn() => this.TransformJobArn != null;

        /// <summary>
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TransformJobName { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobName property is set.
        /// </summary>
        internal bool IsSetTransformJobName() => this.TransformJobName != null;

        /// <summary>
        /// Gets and sets the property TransformJobStatus. 
        /// <para>
        /// The status of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformJobStatus TransformJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobStatus property is set.
        /// </summary>
        internal bool IsSetTransformJobStatus() => this.TransformJobStatus != null;
    }
}
