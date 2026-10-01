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

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// Contains data about a job execution.
    /// </summary>
    public partial class JobExecution
    {
        /// <summary>
        /// Gets and sets the property ApproximateSecondsBeforeTimedOut. 
        /// <para>
        /// The estimated number of seconds that remain before the job execution status will be
        /// changed to <c>TIMED_OUT</c>. The actual job execution timeout can occur up to 60 seconds
        /// later than the estimated duration.
        /// </para>
        /// </summary>
        public long? ApproximateSecondsBeforeTimedOut { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateSecondsBeforeTimedOut property is set.
        /// </summary>
        internal bool IsSetApproximateSecondsBeforeTimedOut() => this.ApproximateSecondsBeforeTimedOut.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// A number that identifies a particular job execution on a particular device. It can
        /// be used later in commands that return or update job execution information.
        /// </para>
        /// </summary>
        public long? ExecutionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionNumber property is set.
        /// </summary>
        internal bool IsSetExecutionNumber() => this.ExecutionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property JobDocument. 
        /// <para>
        /// The content of the job document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string JobDocument { get; set; }

        /// <summary>
        /// Checks to see if the JobDocument property is set.
        /// </summary>
        internal bool IsSetJobDocument() => this.JobDocument != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job execution was last updated. 
        /// </para>
        /// </summary>
        public long? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property QueuedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job execution was enqueued.
        /// </para>
        /// </summary>
        public long? QueuedAt { get; set; }

        /// <summary>
        /// Checks to see if the QueuedAt property is set.
        /// </summary>
        internal bool IsSetQueuedAt() => this.QueuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job execution was started.
        /// </para>
        /// </summary>
        public long? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job execution. Can be one of: "QUEUED", "IN_PROGRESS", "FAILED",
        /// "SUCCESS", "CANCELED", "TIMED_OUT", "REJECTED", or "REMOVED".
        /// </para>
        /// </summary>
        public JobExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A collection of name/value pairs that describe the status of the job execution.
        /// </para>
        ///  
        /// <para>
        /// The maximum length of the value in the name/value pair is 1,024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StatusDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null && (this.StatusDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing that is executing the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version of the job execution. Job execution versions are incremented each time
        /// they are updated by a device.
        /// </para>
        /// </summary>
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
