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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration and status information for a single job retrieved as part
    /// of a job list.
    /// </summary>
    public partial class JobListDescriptor
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when the specified job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-specified description that was included in the specified job's <c>Create
        /// Job</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that the specified job is configured to run on every object listed in
        /// the manifest.
        /// </para>
        /// </summary>
        public OperationName Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The current priority for the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressSummary. 
        /// <para>
        /// Describes the total number of tasks that the specified job has run, the number of
        /// tasks that succeeded, and the number of tasks that failed.
        /// </para>
        /// </summary>
        public JobProgressSummary ProgressSummary { get; set; }

        /// <summary>
        /// Checks to see if the ProgressSummary property is set.
        /// </summary>
        internal bool IsSetProgressSummary() => this.ProgressSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The specified job's current status.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TerminationDate. 
        /// <para>
        /// A timestamp indicating when the specified job terminated. A job's termination date
        /// is the date and time when it succeeded, failed, or was canceled.
        /// </para>
        /// </summary>
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Checks to see if the TerminationDate property is set.
        /// </summary>
        internal bool IsSetTerminationDate() => this.TerminationDate.HasValue;
    }
}
