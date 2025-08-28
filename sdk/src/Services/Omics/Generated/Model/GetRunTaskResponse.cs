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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetRunTask operation.
    /// </summary>
    public partial class GetRunTaskResponse : AmazonWebServiceResponse
    {
        private bool? _cacheHit;
        private string _caches3Uri;
        private int? _cpus;
        private DateTime? _creationTime;
        private string _failureReason;
        private int? _gpus;
        private ImageDetails _imageDetails;
        private string _instanceType;
        private string _logStream;
        private int? _memory;
        private string _name;
        private DateTime? _startTime;
        private TaskStatus _status;
        private string _statusMessage;
        private DateTime? _stopTime;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property CacheHit. 
        /// <para>
        /// Set to true if Amazon Web Services HealthOmics found a matching entry in the run cache
        /// for this task.
        /// </para>
        /// </summary>
        public bool? CacheHit
        {
            get { return this._cacheHit; }
            set { this._cacheHit = value; }
        }

        // Check to see if CacheHit property is set
        internal bool IsSetCacheHit()
        {
            return this._cacheHit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheS3Uri. 
        /// <para>
        /// The S3 URI of the cache location.
        /// </para>
        /// </summary>
        public string CacheS3Uri
        {
            get { return this._caches3Uri; }
            set { this._caches3Uri = value; }
        }

        // Check to see if CacheS3Uri property is set
        internal bool IsSetCacheS3Uri()
        {
            return this._caches3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property Cpus. 
        /// <para>
        /// The task's CPU usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Cpus
        {
            get { return this._cpus; }
            set { this._cpus = value; }
        }

        // Check to see if Cpus property is set
        internal bool IsSetCpus()
        {
            return this._cpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the task was created.
        /// </para>
        /// </summary>
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
        /// The reason a task has failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Gpus. 
        /// <para>
        /// The number of Graphics Processing Units (GPU) specified in the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Gpus
        {
            get { return this._gpus; }
            set { this._gpus = value; }
        }

        // Check to see if Gpus property is set
        internal bool IsSetGpus()
        {
            return this._gpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageDetails. 
        /// <para>
        /// Details about the container image that this task uses.
        /// </para>
        /// </summary>
        public ImageDetails ImageDetails
        {
            get { return this._imageDetails; }
            set { this._imageDetails = value; }
        }

        // Check to see if ImageDetails property is set
        internal bool IsSetImageDetails()
        {
            return this._imageDetails != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for a task.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The task's log stream.
        /// </para>
        /// </summary>
        public string LogStream
        {
            get { return this._logStream; }
            set { this._logStream = value; }
        }

        // Check to see if LogStream property is set
        internal bool IsSetLogStream()
        {
            return this._logStream != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The task's memory use in gigabytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The task's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The task's start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The task's status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public TaskStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The task's status message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The task's stop time.
        /// </para>
        /// </summary>
        public DateTime? StopTime
        {
            get { return this._stopTime; }
            set { this._stopTime = value; }
        }

        // Check to see if StopTime property is set
        internal bool IsSetStopTime()
        {
            return this._stopTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The task's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}