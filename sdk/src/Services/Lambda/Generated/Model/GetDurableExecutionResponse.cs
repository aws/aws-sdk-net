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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The response from the GetDurableExecution operation, containing detailed information
    /// about the durable execution.
    /// </summary>
    public partial class GetDurableExecutionResponse : AmazonWebServiceResponse
    {
        private string _durableExecutionArn;
        private string _durableExecutionName;
        private DateTime? _endTimestamp;
        private ErrorObject _error;
        private string _functionArn;
        private string _inputPayload;
        private string _result;
        private DateTime? _startTimestamp;
        private ExecutionStatus _status;
        private TraceHeader _traceHeader;
        private string _version;

        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DurableExecutionArn
        {
            get { return this._durableExecutionArn; }
            set { this._durableExecutionArn = value; }
        }

        // Check to see if DurableExecutionArn property is set
        internal bool IsSetDurableExecutionArn()
        {
            return this._durableExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DurableExecutionName. 
        /// <para>
        /// The name of the durable execution. This is either the name you provided when invoking
        /// the function, or a system-generated unique identifier if no name was provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DurableExecutionName
        {
            get { return this._durableExecutionName; }
            set { this._durableExecutionName = value; }
        }

        // Check to see if DurableExecutionName property is set
        internal bool IsSetDurableExecutionName()
        {
            return this._durableExecutionName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The date and time when the durable execution ended, in Unix timestamp format. This
        /// field is only present if the execution has completed (status is <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>STOPPED</c>).
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error information if the durable execution failed. This field is only present when
        /// the execution status is <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>STOPPED</c>. The combined
        /// size of all error fields is limited to 256 KB.
        /// </para>
        /// </summary>
        public ErrorObject Error
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function that was invoked to start this
        /// durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputPayload. 
        /// <para>
        /// The JSON input payload that was provided when the durable execution was started. For
        /// asynchronous invocations, this is limited to 256 KB. For synchronous invocations,
        /// this can be up to 6 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=6291456)]
        public string InputPayload
        {
            get { return this._inputPayload; }
            set { this._inputPayload = value; }
        }

        // Check to see if InputPayload property is set
        internal bool IsSetInputPayload()
        {
            return this._inputPayload != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The JSON result returned by the durable execution if it completed successfully. This
        /// field is only present when the execution status is <c>SUCCEEDED</c>. The result is
        /// limited to 256 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=6291456)]
        public string Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the durable execution started, in Unix timestamp format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the durable execution. Valid values are <c>RUNNING</c>, <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, and <c>STOPPED</c>.
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
        /// Gets and sets the property TraceHeader. 
        /// <para>
        /// The trace headers associated with the durable execution.
        /// </para>
        /// </summary>
        public TraceHeader TraceHeader
        {
            get { return this._traceHeader; }
            set { this._traceHeader = value; }
        }

        // Check to see if TraceHeader property is set
        internal bool IsSetTraceHeader()
        {
            return this._traceHeader != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Lambda function that was invoked for this durable execution. This
        /// ensures that all replays during the execution use the same function version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}