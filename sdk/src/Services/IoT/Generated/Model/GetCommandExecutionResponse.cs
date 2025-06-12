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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetCommandExecution operation.
    /// </summary>
    public partial class GetCommandExecutionResponse : AmazonWebServiceResponse
    {
        private string _commandArn;
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private string _executionId;
        private long? _executionTimeoutSeconds;
        private DateTime? _lastUpdatedAt;
        private Dictionary<string, CommandParameterValue> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, CommandParameterValue>() : null;
        private Dictionary<string, CommandExecutionResult> _result = AWSConfigs.InitializeCollections ? new Dictionary<string, CommandExecutionResult>() : null;
        private DateTime? _startedAt;
        private CommandExecutionStatus _status;
        private StatusReason _statusReason;
        private string _targetArn;
        private DateTime? _timeToLive;

        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. For example, <code/>arn:aws:iot:&lt;region&gt;:&lt;accountid&gt;:command/&lt;commandId&gt;
        /// </para>
        /// </summary>
        public string CommandArn
        {
            get { return this._commandArn; }
            set { this._commandArn = value; }
        }

        // Check to see if CommandArn property is set
        internal bool IsSetCommandArn()
        {
            return this._commandArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp, when the command execution was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp, when the command execution was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
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
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier of the command execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutSeconds. 
        /// <para>
        /// Specifies the amount of time in seconds that the device can take to finish a command
        /// execution. A timer starts when the command execution is created. If the command execution
        /// status is not set to another terminal state before the timer expires, it will automatically
        /// update to <c>TIMED_OUT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ExecutionTimeoutSeconds
        {
            get { return this._executionTimeoutSeconds; }
            set { this._executionTimeoutSeconds = value; }
        }

        // Check to see if ExecutionTimeoutSeconds property is set
        internal bool IsSetExecutionTimeoutSeconds()
        {
            return this._executionTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp, when the command execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The list of parameters that the <c>StartCommandExecution</c> API used when performing
        /// the command on the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, CommandParameterValue> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result value for the current state of the command execution. The status provides
        /// information about the progress of the command execution. The device can use the result
        /// field to share additional details about the execution such as a return value of a
        /// remote function call.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the <c>AWS-IoT-FleetWise</c> namespace, then this field is not applicable
        /// in the API response.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, CommandExecutionResult> Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null && (this._result.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp, when the command execution was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
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
        /// The status of the command execution. After your devices receive the command and start
        /// performing the operations specified in the command, it can use the <c>UpdateCommandExecution</c>
        /// MQTT API to update the status information.
        /// </para>
        /// </summary>
        public CommandExecutionStatus Status
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
        /// Your devices can use this parameter to provide additional context about the status
        /// of a command execution using a reason code and description.
        /// </para>
        /// </summary>
        public StatusReason StatusReason
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
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the device on which the command execution is being
        /// performed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The time to live (TTL) parameter that indicates the duration for which executions
        /// will be retained in your account. The default value is six months.
        /// </para>
        /// </summary>
        public DateTime? TimeToLive
        {
            get { return this._timeToLive; }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive.HasValue; 
        }

    }
}