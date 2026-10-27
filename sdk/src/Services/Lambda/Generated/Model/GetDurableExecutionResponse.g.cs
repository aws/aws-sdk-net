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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetDurableExecution operation.
    /// </summary>
    public partial class GetDurableExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DurableConfig. 
        /// <para>
        /// Configuration settings for the durable execution, including execution timeout, retention
        /// period for execution history, and an optional ARN of the Key Management Service (KMS)
        /// customer managed key that is used to encrypt your durable execution's payload data,
        /// including input, output, and error payloads.
        /// </para>
        /// </summary>
        public DurableConfig DurableConfig { get; set; }

        /// <summary>
        /// Checks to see if the DurableConfig property is set.
        /// </summary>
        internal bool IsSetDurableConfig() => this.DurableConfig != null;

        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DurableExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionArn property is set.
        /// </summary>
        internal bool IsSetDurableExecutionArn() => this.DurableExecutionArn != null;

        /// <summary>
        /// Gets and sets the property DurableExecutionName. 
        /// <para>
        /// The name of the durable execution. This is either the name you provided when invoking
        /// the function, or a system-generated unique identifier if no name was provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DurableExecutionName { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionName property is set.
        /// </summary>
        internal bool IsSetDurableExecutionName() => this.DurableExecutionName != null;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The date and time when the durable execution ended, in Unix timestamp format. This
        /// field is only present if the execution has completed (status is <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>STOPPED</c>).
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error information if the durable execution failed. This field is only present when
        /// the execution status is <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>STOPPED</c>. The combined
        /// size of all error fields is limited to 1 MB.
        /// </para>
        /// </summary>
        public ErrorObject Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ExecutionDataIncluded. 
        /// <para>
        /// Indicates whether execution data is included in this response. Returns <c>false</c>
        /// when <c>IncludeExecutionData</c> is set to <c>false</c> in the request.
        /// </para>
        /// </summary>
        public bool? ExecutionDataIncluded { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionDataIncluded property is set.
        /// </summary>
        internal bool IsSetExecutionDataIncluded() => this.ExecutionDataIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function that was invoked to start this
        /// durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property InputPayload. 
        /// <para>
        /// The JSON input payload that you provided when you started the durable execution. Asynchronous
        /// invocations support up to 1 MB, and synchronous invocations support up to 6 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 6291456)]
        public string InputPayload { get; set; }

        /// <summary>
        /// Checks to see if the InputPayload property is set.
        /// </summary>
        internal bool IsSetInputPayload() => this.InputPayload != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The JSON result returned by the durable execution if it completed successfully. This
        /// field is only present when the execution status is <c>SUCCEEDED</c>. Asynchronous
        /// invocations support up to 1 MB, and synchronous invocations support up to 6 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 6291456)]
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the durable execution started, in Unix timestamp format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the durable execution. Valid values are <c>RUNNING</c>, <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, and <c>STOPPED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TraceHeader. 
        /// <para>
        /// The trace headers associated with the durable execution.
        /// </para>
        /// </summary>
        public TraceHeader TraceHeader { get; set; }

        /// <summary>
        /// Checks to see if the TraceHeader property is set.
        /// </summary>
        internal bool IsSetTraceHeader() => this.TraceHeader != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Lambda function that was invoked for this durable execution. This
        /// ensures that all replays during the execution use the same function version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
