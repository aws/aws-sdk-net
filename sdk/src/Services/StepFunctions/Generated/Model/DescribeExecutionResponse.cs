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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the DescribeExecution operation.
    /// </summary>
    public partial class DescribeExecutionResponse : AmazonWebServiceResponse
    {
        private string _cause;
        private string _error;
        private string _executionArn;
        private string _input;
        private CloudWatchEventsExecutionDataDetails _inputDetails;
        private string _mapRunArn;
        private string _name;
        private string _output;
        private CloudWatchEventsExecutionDataDetails _outputDetails;
        private int? _redriveCount;
        private DateTime? _redriveDate;
        private ExecutionRedriveStatus _redriveStatus;
        private string _redriveStatusReason;
        private DateTime? _startDate;
        private string _stateMachineAliasArn;
        private string _stateMachineArn;
        private string _stateMachineVersionArn;
        private ExecutionStatus _status;
        private DateTime? _stopDate;
        private string _traceHeader;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The cause string if the state machine execution failed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=32768)]
        public string Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error string if the state machine execution failed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExecutionArn
        {
            get { return this._executionArn; }
            set { this._executionArn = value; }
        }

        // Check to see if ExecutionArn property is set
        internal bool IsSetExecutionArn()
        {
            return this._executionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The string that contains the JSON input data of the execution. Length constraints
        /// apply to the payload size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property InputDetails.
        /// </summary>
        public CloudWatchEventsExecutionDataDetails InputDetails
        {
            get { return this._inputDetails; }
            set { this._inputDetails = value; }
        }

        // Check to see if InputDetails property is set
        internal bool IsSetInputDetails()
        {
            return this._inputDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies a Map Run, which dispatched this execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string MapRunArn
        {
            get { return this._mapRunArn; }
            set { this._mapRunArn = value; }
        }

        // Check to see if MapRunArn property is set
        internal bool IsSetMapRunArn()
        {
            return this._mapRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the execution.
        /// </para>
        ///  
        /// <para>
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// white space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <c>&lt; &gt; { } [ ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <c>? *</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <c>" # % \ ^ | ~ ` $ &amp; , ; : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<c>U+0000-001F</c>, <c>U+007F-009F</c>, <c>U+FFFE-FFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// surrogates (<c>U+D800-DFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// invalid characters (<c> U+10FFFF</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable logging with CloudWatch Logs, the name should only contain 0-9, A-Z, a-z,
        /// - and _.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
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
        /// Gets and sets the property Output. 
        /// <para>
        /// The JSON output data of the execution. Length constraints apply to the payload size,
        /// and are expressed as bytes in UTF-8 encoding.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is set only if the execution succeeds. If the execution fails, this field
        /// is null.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDetails.
        /// </summary>
        public CloudWatchEventsExecutionDataDetails OutputDetails
        {
            get { return this._outputDetails; }
            set { this._outputDetails = value; }
        }

        // Check to see if OutputDetails property is set
        internal bool IsSetOutputDetails()
        {
            return this._outputDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RedriveCount. 
        /// <para>
        /// The number of times you've redriven an execution. If you have not yet redriven an
        /// execution, the <c>redriveCount</c> is 0. This count is only updated if you successfully
        /// redrive an execution.
        /// </para>
        /// </summary>
        public int? RedriveCount
        {
            get { return this._redriveCount; }
            set { this._redriveCount = value; }
        }

        // Check to see if RedriveCount property is set
        internal bool IsSetRedriveCount()
        {
            return this._redriveCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedriveDate. 
        /// <para>
        /// The date the execution was last redriven. If you have not yet redriven an execution,
        /// the <c>redriveDate</c> is null.
        /// </para>
        ///  
        /// <para>
        /// The <c>redriveDate</c> is unavailable if you redrive a Map Run that starts child workflow
        /// executions of type <c>EXPRESS</c>.
        /// </para>
        /// </summary>
        public DateTime? RedriveDate
        {
            get { return this._redriveDate; }
            set { this._redriveDate = value; }
        }

        // Check to see if RedriveDate property is set
        internal bool IsSetRedriveDate()
        {
            return this._redriveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedriveStatus. 
        /// <para>
        /// Indicates whether or not an execution can be redriven at a given point in time.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For executions of type <c>STANDARD</c>, <c>redriveStatus</c> is <c>NOT_REDRIVABLE</c>
        /// if calling the <a>RedriveExecution</a> API action would return the <c>ExecutionNotRedrivable</c>
        /// error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Distributed Map that includes child workflows of type <c>STANDARD</c>, <c>redriveStatus</c>
        /// indicates whether or not the Map Run can redrive child workflow executions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Distributed Map that includes child workflows of type <c>EXPRESS</c>, <c>redriveStatus</c>
        /// indicates whether or not the Map Run can redrive child workflow executions.
        /// </para>
        ///  
        /// <para>
        /// You can redrive failed or timed out <c>EXPRESS</c> workflows <i>only if</i> they're
        /// a part of a Map Run. When you <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-map-run.html">redrive</a>
        /// the Map Run, these workflows are restarted using the <a>StartExecution</a> API action.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionRedriveStatus RedriveStatus
        {
            get { return this._redriveStatus; }
            set { this._redriveStatus = value; }
        }

        // Check to see if RedriveStatus property is set
        internal bool IsSetRedriveStatus()
        {
            return this._redriveStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RedriveStatusReason. 
        /// <para>
        /// When <c>redriveStatus</c> is <c>NOT_REDRIVABLE</c>, <c>redriveStatusReason</c> specifies
        /// the reason why an execution cannot be redriven.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For executions of type <c>STANDARD</c>, or for a Distributed Map that includes child
        /// workflows of type <c>STANDARD</c>, <c>redriveStatusReason</c> can include one of the
        /// following reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>State machine is in DELETING status</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Execution is RUNNING and cannot be redriven</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Execution is SUCCEEDED and cannot be redriven</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Execution was started before the launch of RedriveExecution</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Execution history event limit exceeded</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Execution has exceeded the max execution time</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Execution redrivable period exceeded</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For a Distributed Map that includes child workflows of type <c>EXPRESS</c>, <c>redriveStatusReason</c>
        /// is only returned if the child workflows are not redrivable. This happens when the
        /// child workflow executions have completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string RedriveStatusReason
        {
            get { return this._redriveStatusReason; }
            set { this._redriveStatusReason = value; }
        }

        // Check to see if RedriveStatusReason property is set
        internal bool IsSetRedriveStatusReason()
        {
            return this._redriveStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the execution is started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateMachineAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine alias associated with the execution.
        /// The alias ARN is a combination of state machine ARN and the alias name separated by
        /// a colon (:). For example, <c>stateMachineARN:PROD</c>.
        /// </para>
        ///  
        /// <para>
        /// If you start an execution from a <c>StartExecution</c> request with a state machine
        /// version ARN, this field will be null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateMachineAliasArn
        {
            get { return this._stateMachineAliasArn; }
            set { this._stateMachineAliasArn = value; }
        }

        // Check to see if StateMachineAliasArn property is set
        internal bool IsSetStateMachineAliasArn()
        {
            return this._stateMachineAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the executed stated machine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StateMachineArn
        {
            get { return this._stateMachineArn; }
            set { this._stateMachineArn = value; }
        }

        // Check to see if StateMachineArn property is set
        internal bool IsSetStateMachineArn()
        {
            return this._stateMachineArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine version associated with the execution.
        /// The version ARN is a combination of state machine ARN and the version number separated
        /// by a colon (:). For example, <c>stateMachineARN:1</c>.
        /// </para>
        ///  
        /// <para>
        /// If you start an execution from a <c>StartExecution</c> request without specifying
        /// a state machine version or alias ARN, Step Functions returns a null value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateMachineVersionArn
        {
            get { return this._stateMachineVersionArn; }
            set { this._stateMachineVersionArn = value; }
        }

        // Check to see if StateMachineVersionArn property is set
        internal bool IsSetStateMachineVersionArn()
        {
            return this._stateMachineVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus Status
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
        /// Gets and sets the property StopDate. 
        /// <para>
        /// If the execution ended, the date the execution stopped.
        /// </para>
        /// </summary>
        public DateTime? StopDate
        {
            get { return this._stopDate; }
            set { this._stopDate = value; }
        }

        // Check to see if StopDate property is set
        internal bool IsSetStopDate()
        {
            return this._stopDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TraceHeader. 
        /// <para>
        /// The X-Ray trace header that was passed to the execution.
        /// </para>
        ///  <note> 
        /// <para>
        ///  For X-Ray traces, all Amazon Web Services services use the <c>X-Amzn-Trace-Id</c>
        /// header from the HTTP request. Using the header is the preferred mechanism to identify
        /// a trace. <c>StartExecution</c> and <c>StartSyncExecution</c> API operations can also
        /// use <c>traceHeader</c> from the body of the request payload. If <b>both</b> sources
        /// are provided, Step Functions will use the <b>header value</b> (preferred) over the
        /// value in the request body. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TraceHeader
        {
            get { return this._traceHeader; }
            set { this._traceHeader = value; }
        }

        // Check to see if TraceHeader property is set
        internal bool IsSetTraceHeader()
        {
            return this._traceHeader != null;
        }

    }
}