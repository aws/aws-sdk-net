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
    /// Container for the parameters to the StartSyncExecution operation.
    /// Starts a Synchronous Express state machine execution. <c>StartSyncExecution</c> is
    /// not available for <c>STANDARD</c> workflows.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>StartSyncExecution</c> will return a <c>200 OK</c> response, even if your execution
    /// fails, because the status code in the API response doesn't reflect function errors.
    /// Error codes are reserved for errors that prevent your execution from running, such
    /// as permissions errors, limit errors, or issues with your state machine code and configuration.
    /// 
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// This API action isn't logged in CloudTrail.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartSyncExecutionRequest : AmazonStepFunctionsRequest
    {
        private IncludedData _includedData;
        private string _input;
        private string _name;
        private string _stateMachineArn;
        private string _traceHeader;

        /// <summary>
        /// Gets and sets the property IncludedData. 
        /// <para>
        /// If your state machine definition is encrypted with a KMS key, callers must have <c>kms:Decrypt</c>
        /// permission to decrypt the definition. Alternatively, you can call the API with <c>includedData
        /// = METADATA_ONLY</c> to get a successful response without the encrypted definition.
        /// </para>
        /// </summary>
        public IncludedData IncludedData
        {
            get { return this._includedData; }
            set { this._includedData = value; }
        }

        // Check to see if IncludedData property is set
        internal bool IsSetIncludedData()
        {
            return this._includedData != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The string that contains the JSON input data for the execution, for example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"first_name\" : \"Alejandro\"}"</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't include any JSON input data, you still must include the two braces, for
        /// example: <c>"{}"</c> 
        /// </para>
        ///  </note> 
        /// <para>
        /// Length constraints apply to the payload size, and are expressed as bytes in UTF-8
        /// encoding.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the execution.
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
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine to execute.
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
        /// Gets and sets the property TraceHeader. 
        /// <para>
        /// Passes the X-Ray trace header. The trace header can also be passed in the request
        /// payload.
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