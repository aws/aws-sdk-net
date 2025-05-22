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
    /// Summary of information about a processing job.
    /// </summary>
    public partial class ProcessingJobSummary
    {
        private DateTime? _creationTime;
        private string _exitMessage;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private DateTime? _processingEndTime;
        private string _processingJobArn;
        private string _processingJobName;
        private ProcessingJobStatus _processingJobStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the processing job was created.
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
        /// Gets and sets the property ExitMessage. 
        /// <para>
        /// An optional string, up to one KB in size, that contains metadata from the processing
        /// container when the processing job exits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ExitMessage
        {
            get { return this._exitMessage; }
            set { this._exitMessage = value; }
        }

        // Check to see if ExitMessage property is set
        internal bool IsSetExitMessage()
        {
            return this._exitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A string, up to one KB in size, that contains the reason a processing job failed,
        /// if it failed.
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
        /// A timestamp that indicates the last time the processing job was modified.
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
        /// Gets and sets the property ProcessingEndTime. 
        /// <para>
        /// The time at which the processing job completed.
        /// </para>
        /// </summary>
        public DateTime? ProcessingEndTime
        {
            get { return this._processingEndTime; }
            set { this._processingEndTime = value; }
        }

        // Check to see if ProcessingEndTime property is set
        internal bool IsSetProcessingEndTime()
        {
            return this._processingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the processing job..
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ProcessingJobArn
        {
            get { return this._processingJobArn; }
            set { this._processingJobArn = value; }
        }

        // Check to see if ProcessingJobArn property is set
        internal bool IsSetProcessingJobArn()
        {
            return this._processingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobName. 
        /// <para>
        /// The name of the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ProcessingJobName
        {
            get { return this._processingJobName; }
            set { this._processingJobName = value; }
        }

        // Check to see if ProcessingJobName property is set
        internal bool IsSetProcessingJobName()
        {
            return this._processingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobStatus. 
        /// <para>
        /// The status of the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingJobStatus ProcessingJobStatus
        {
            get { return this._processingJobStatus; }
            set { this._processingJobStatus = value; }
        }

        // Check to see if ProcessingJobStatus property is set
        internal bool IsSetProcessingJobStatus()
        {
            return this._processingJobStatus != null;
        }

    }
}