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
    /// Summary information about a service job.
    /// </summary>
    public partial class ServiceJobSummary
    {
        private long? _createdAt;
        private string _jobArn;
        private string _jobId;
        private string _jobName;
        private LatestServiceJobAttempt _latestAttempt;
        private ServiceJobType _serviceJobType;
        private string _shareIdentifier;
        private long? _startedAt;
        private ServiceJobStatus _status;
        private string _statusReason;
        private long? _stoppedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job was created.
        /// </para>
        /// </summary>
        public long? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service job.
        /// </para>
        /// </summary>
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID for the service job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the service job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestAttempt. 
        /// <para>
        /// Information about the latest attempt for the service job.
        /// </para>
        /// </summary>
        public LatestServiceJobAttempt LatestAttempt
        {
            get { return this._latestAttempt; }
            set { this._latestAttempt = value; }
        }

        // Check to see if LatestAttempt property is set
        internal bool IsSetLatestAttempt()
        {
            return this._latestAttempt != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceJobType. 
        /// <para>
        /// The type of service job. For SageMaker Training jobs, this value is <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceJobType ServiceJobType
        {
            get { return this._serviceJobType; }
            set { this._serviceJobType = value; }
        }

        // Check to see if ServiceJobType property is set
        internal bool IsSetServiceJobType()
        {
            return this._serviceJobType != null;
        }

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the job.
        /// </para>
        /// </summary>
        public string ShareIdentifier
        {
            get { return this._shareIdentifier; }
            set { this._shareIdentifier = value; }
        }

        // Check to see if ShareIdentifier property is set
        internal bool IsSetShareIdentifier()
        {
            return this._shareIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job was started.
        /// </para>
        /// </summary>
        public long? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the service job. 
        /// </para>
        /// </summary>
        public ServiceJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short string to provide more details on the current status of the service job.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job stopped running.
        /// </para>
        /// </summary>
        public long? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

    }
}