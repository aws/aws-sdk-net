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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the StartSyncExecution operation.
    /// </summary>
    public partial class StartSyncExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BillingDetails. 
        /// <para>
        /// An object that describes workflow billing details, including billed duration and memory
        /// use.
        /// </para>
        /// </summary>
        public BillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Checks to see if the BillingDetails property is set.
        /// </summary>
        internal bool IsSetBillingDetails() => this.BillingDetails != null;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// A more detailed explanation of the cause of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 32768)]
        public string Cause { get; set; }

        /// <summary>
        /// Checks to see if the Cause property is set.
        /// </summary>
        internal bool IsSetCause() => this.Cause != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error code of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionArn property is set.
        /// </summary>
        internal bool IsSetExecutionArn() => this.ExecutionArn != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The string that contains the JSON input data of the execution. Length constraints
        /// apply to the payload size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property InputDetails.
        /// </summary>
        public CloudWatchEventsExecutionDataDetails InputDetails { get; set; }

        /// <summary>
        /// Checks to see if the InputDetails property is set.
        /// </summary>
        internal bool IsSetInputDetails() => this.InputDetails != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property OutputDetails.
        /// </summary>
        public CloudWatchEventsExecutionDataDetails OutputDetails { get; set; }

        /// <summary>
        /// Checks to see if the OutputDetails property is set.
        /// </summary>
        internal bool IsSetOutputDetails() => this.OutputDetails != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the execution is started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the state machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StateMachineArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineArn property is set.
        /// </summary>
        internal bool IsSetStateMachineArn() => this.StateMachineArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StopDate. 
        /// <para>
        /// If the execution has already ended, the date the execution stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StopDate { get; set; }

        /// <summary>
        /// Checks to see if the StopDate property is set.
        /// </summary>
        internal bool IsSetStopDate() => this.StopDate.HasValue;

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
        [AWSProperty(Min = 0, Max = 256)]
        public string TraceHeader { get; set; }

        /// <summary>
        /// Checks to see if the TraceHeader property is set.
        /// </summary>
        internal bool IsSetTraceHeader() => this.TraceHeader != null;
    }
}
