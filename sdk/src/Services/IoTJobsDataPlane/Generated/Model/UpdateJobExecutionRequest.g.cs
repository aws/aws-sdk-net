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
    /// Container for the parameters to the UpdateJobExecution operation. Updates the status
    /// of a job execution. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiotjobsdataplane.html">UpdateJobExecution</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateJobExecutionRequest : AmazonIoTJobsDataPlaneRequest
    {
        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// Optional. A number that identifies a particular job execution on a particular device.
        /// </para>
        /// </summary>
        public long? ExecutionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionNumber property is set.
        /// </summary>
        internal bool IsSetExecutionNumber() => this.ExecutionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// Optional. The expected current version of the job execution. Each time you update
        /// the job execution, its version is incremented. If the version of the job execution
        /// stored in Jobs does not match, the update is rejected with a VersionMismatch error,
        /// and an ErrorResponse that contains the current job execution status data is returned.
        /// (This makes it unnecessary to perform a separate DescribeJobExecution request in order
        /// to obtain the job execution status data.)
        /// </para>
        /// </summary>
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedVersion property is set.
        /// </summary>
        internal bool IsSetExpectedVersion() => this.ExpectedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeJobDocument. 
        /// <para>
        /// Optional. When set to true, the response contains the job document. The default is
        /// false.
        /// </para>
        /// </summary>
        public bool? IncludeJobDocument { get; set; }

        /// <summary>
        /// Checks to see if the IncludeJobDocument property is set.
        /// </summary>
        internal bool IsSetIncludeJobDocument() => this.IncludeJobDocument.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeJobExecutionState. 
        /// <para>
        /// Optional. When included and set to true, the response contains the JobExecutionState
        /// data. The default is false.
        /// </para>
        /// </summary>
        public bool? IncludeJobExecutionState { get; set; }

        /// <summary>
        /// Checks to see if the IncludeJobExecutionState property is set.
        /// </summary>
        internal bool IsSetIncludeJobExecutionState() => this.IncludeJobExecutionState.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status for the job execution (IN_PROGRESS, FAILED, SUCCESS, or REJECTED).
        /// This must be specified on every update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        ///  Optional. A collection of name/value pairs that describe the status of the job execution.
        /// If not specified, the statusDetails are unchanged.
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
        /// Gets and sets the property StepTimeoutInMinutes. 
        /// <para>
        /// Specifies the amount of time this device has to finish execution of this job. If the
        /// job execution status is not set to a terminal state before this timer expires, or
        /// before the timer is reset (by again calling <c>UpdateJobExecution</c>, setting the
        /// status to <c>IN_PROGRESS</c>, and specifying a new timeout value in this field) the
        /// job execution status will be automatically set to <c>TIMED_OUT</c>. Note that setting
        /// or resetting the step timeout has no effect on the in progress timeout that may have
        /// been specified when the job was created (<c>CreateJob</c> using field <c>timeoutConfig</c>).
        /// </para>
        ///  
        /// <para>
        /// Valid values for this parameter range from 1 to 10080 (1 minute to 7 days). A value
        /// of -1 is also valid and will cancel the current step timer (created by an earlier
        /// use of <c>UpdateJobExecutionRequest</c>).
        /// </para>
        /// </summary>
        public long? StepTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the StepTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetStepTimeoutInMinutes() => this.StepTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing associated with the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;
    }
}
