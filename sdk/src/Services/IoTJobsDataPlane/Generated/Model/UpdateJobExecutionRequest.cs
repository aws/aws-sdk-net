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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
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
    /// Container for the parameters to the UpdateJobExecution operation.
    /// Updates the status of a job execution.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiotjobsdataplane.html">UpdateJobExecution</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateJobExecutionRequest : AmazonIoTJobsDataPlaneRequest
    {
        private long? _executionNumber;
        private long? _expectedVersion;
        private bool? _includeJobDocument;
        private bool? _includeJobExecutionState;
        private string _jobId;
        private JobExecutionStatus _status;
        private Dictionary<string, string> _statusDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _stepTimeoutInMinutes;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// Optional. A number that identifies a particular job execution on a particular device.
        /// </para>
        /// </summary>
        public long? ExecutionNumber
        {
            get { return this._executionNumber; }
            set { this._executionNumber = value; }
        }

        // Check to see if ExecutionNumber property is set
        internal bool IsSetExecutionNumber()
        {
            return this._executionNumber.HasValue; 
        }

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
        public long? ExpectedVersion
        {
            get { return this._expectedVersion; }
            set { this._expectedVersion = value; }
        }

        // Check to see if ExpectedVersion property is set
        internal bool IsSetExpectedVersion()
        {
            return this._expectedVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeJobDocument. 
        /// <para>
        /// Optional. When set to true, the response contains the job document. The default is
        /// false.
        /// </para>
        /// </summary>
        public bool? IncludeJobDocument
        {
            get { return this._includeJobDocument; }
            set { this._includeJobDocument = value; }
        }

        // Check to see if IncludeJobDocument property is set
        internal bool IsSetIncludeJobDocument()
        {
            return this._includeJobDocument.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeJobExecutionState. 
        /// <para>
        /// Optional. When included and set to true, the response contains the JobExecutionState
        /// data. The default is false.
        /// </para>
        /// </summary>
        public bool? IncludeJobExecutionState
        {
            get { return this._includeJobExecutionState; }
            set { this._includeJobExecutionState = value; }
        }

        // Check to see if IncludeJobExecutionState property is set
        internal bool IsSetIncludeJobExecutionState()
        {
            return this._includeJobExecutionState.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status for the job execution (IN_PROGRESS, FAILED, SUCCESS, or REJECTED).
        /// This must be specified on every update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobExecutionStatus Status
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null && (this._statusDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public long? StepTimeoutInMinutes
        {
            get { return this._stepTimeoutInMinutes; }
            set { this._stepTimeoutInMinutes = value; }
        }

        // Check to see if StepTimeoutInMinutes property is set
        internal bool IsSetStepTimeoutInMinutes()
        {
            return this._stepTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing associated with the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}