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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetRunTask operation.
    /// </summary>
    public partial class GetRunTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CacheHit. 
        /// <para>
        /// Set to true if Amazon Web Services HealthOmics found a matching entry in the run cache
        /// for this task.
        /// </para>
        /// </summary>
        public bool? CacheHit { get; set; }

        /// <summary>
        /// Checks to see if the CacheHit property is set.
        /// </summary>
        internal bool IsSetCacheHit() => this.CacheHit.HasValue;

        /// <summary>
        /// Gets and sets the property CacheS3Uri. 
        /// <para>
        /// The S3 URI of the cache location.
        /// </para>
        /// </summary>
        public string CacheS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the CacheS3Uri property is set.
        /// </summary>
        internal bool IsSetCacheS3Uri() => this.CacheS3Uri != null;

        /// <summary>
        /// Gets and sets the property Cpus. 
        /// <para>
        /// The task's CPU usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Cpus { get; set; }

        /// <summary>
        /// Checks to see if the Cpus property is set.
        /// </summary>
        internal bool IsSetCpus() => this.Cpus.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason a task has failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Gpus. 
        /// <para>
        /// The number of Graphics Processing Units (GPU) specified in the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Gpus { get; set; }

        /// <summary>
        /// Checks to see if the Gpus property is set.
        /// </summary>
        internal bool IsSetGpus() => this.Gpus.HasValue;

        /// <summary>
        /// Gets and sets the property ImageDetails. 
        /// <para>
        /// Details about the container image that this task uses.
        /// </para>
        /// </summary>
        public ImageDetails ImageDetails { get; set; }

        /// <summary>
        /// Checks to see if the ImageDetails property is set.
        /// </summary>
        internal bool IsSetImageDetails() => this.ImageDetails != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for a task.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The task's log stream.
        /// </para>
        /// </summary>
        public string LogStream { get; set; }

        /// <summary>
        /// Checks to see if the LogStream property is set.
        /// </summary>
        internal bool IsSetLogStream() => this.LogStream != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The task's memory use in gigabytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The task's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The task's start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The task's status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The task's status message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The task's stop time.
        /// </para>
        /// </summary>
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Checks to see if the StopTime property is set.
        /// </summary>
        internal bool IsSetStopTime() => this.StopTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The task's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier (UUID) for the workflow task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Uuid { get; set; }

        /// <summary>
        /// Checks to see if the Uuid property is set.
        /// </summary>
        internal bool IsSetUuid() => this.Uuid != null;
    }
}
