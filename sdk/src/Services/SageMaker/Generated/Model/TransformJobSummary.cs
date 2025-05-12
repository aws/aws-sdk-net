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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private DateTime? _creationTime;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private DateTime? _transformEndTime;
        private string _transformJobArn;
        private string _transformJobName;
        private TransformJobStatus _transformJobStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the transform Job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the transform job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Indicates when the transform job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransformEndTime. 
        /// <para>
        /// Indicates when the transform job ends on compute instances. For successful jobs and
        /// stopped jobs, this is the exact time recorded after the results are uploaded. For
        /// failed jobs, this is when Amazon SageMaker detected that the job failed.
        /// </para>
        /// </summary>
        public DateTime? TransformEndTime
        {
            get { return this._transformEndTime; }
            set { this._transformEndTime = value; }
        }

        // Check to see if TransformEndTime property is set
        internal bool IsSetTransformEndTime()
        {
            return this._transformEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransformJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string TransformJobArn
        {
            get { return this._transformJobArn; }
            set { this._transformJobArn = value; }
        }

        // Check to see if TransformJobArn property is set
        internal bool IsSetTransformJobArn()
        {
            return this._transformJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TransformJobName
        {
            get { return this._transformJobName; }
            set { this._transformJobName = value; }
        }

        // Check to see if TransformJobName property is set
        internal bool IsSetTransformJobName()
        {
            return this._transformJobName != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobStatus. 
        /// <para>
        /// The status of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformJobStatus TransformJobStatus
        {
            get { return this._transformJobStatus; }
            set { this._transformJobStatus = value; }
        }

        // Check to see if TransformJobStatus property is set
        internal bool IsSetTransformJobStatus()
        {
            return this._transformJobStatus != null;
        }

    }
}