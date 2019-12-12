/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides a summary about a job.
    /// </summary>
    public partial class AutoMLJobSummary
    {
        private string _autoMLJobArn;
        private string _autoMLJobName;
        private AutoMLJobSecondaryStatus _autoMLJobSecondaryStatus;
        private AutoMLJobStatus _autoMLJobStatus;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _failureReason;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The ARN of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AutoMLJobArn
        {
            get { return this._autoMLJobArn; }
            set { this._autoMLJobArn = value; }
        }

        // Check to see if AutoMLJobArn property is set
        internal bool IsSetAutoMLJobArn()
        {
            return this._autoMLJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// The name of the object you are requesting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AutoMLJobName
        {
            get { return this._autoMLJobName; }
            set { this._autoMLJobName = value; }
        }

        // Check to see if AutoMLJobName property is set
        internal bool IsSetAutoMLJobName()
        {
            return this._autoMLJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobSecondaryStatus. 
        /// <para>
        /// The job's secondary status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLJobSecondaryStatus AutoMLJobSecondaryStatus
        {
            get { return this._autoMLJobSecondaryStatus; }
            set { this._autoMLJobSecondaryStatus = value; }
        }

        // Check to see if AutoMLJobSecondaryStatus property is set
        internal bool IsSetAutoMLJobSecondaryStatus()
        {
            return this._autoMLJobSecondaryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobStatus. 
        /// <para>
        /// The job's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLJobStatus AutoMLJobStatus
        {
            get { return this._autoMLJobStatus; }
            set { this._autoMLJobStatus = value; }
        }

        // Check to see if AutoMLJobStatus property is set
        internal bool IsSetAutoMLJobStatus()
        {
            return this._autoMLJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// When the job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}