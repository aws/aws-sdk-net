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
    /// Container for the parameters to the StartExecution operation.
    /// Starts a state machine execution.
    /// 
    ///  
    /// <para>
    /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
    /// within a state machine, a version ARN, or an alias ARN.
    /// </para>
    ///  
    /// <para>
    /// The following are some examples of qualified and unqualified state machine ARNs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
    /// with a label <c>mapStateLabel</c> in a state machine named <c>myStateMachine</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</c>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
    /// the request fails with <c>ValidationException</c>.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The following qualified state machine ARN refers to an alias named <c>PROD</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</c>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
    /// ARN, the request starts execution for that version or alias.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The following unqualified state machine ARN refers to a state machine named <c>myStateMachine</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</c>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you start an execution with an unqualified state machine ARN, Step Functions uses
    /// the latest revision of the state machine for the execution.
    /// </para>
    ///  
    /// <para>
    /// To start executions of a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>,
    /// call <c>StartExecution</c> and provide the version ARN or the ARN of an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
    /// that points to the version.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>StartExecution</c> is idempotent for <c>STANDARD</c> workflows. For a <c>STANDARD</c>
    /// workflow, if you call <c>StartExecution</c> with the same name and input as a running
    /// execution, the call succeeds and return the same response as the original request.
    /// If the execution is closed or if the input is different, it returns a <c>400 ExecutionAlreadyExists</c>
    /// error. You can reuse names after 90 days. 
    /// </para>
    ///  
    /// <para>
    ///  <c>StartExecution</c> isn't idempotent for <c>EXPRESS</c> workflows. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartExecutionRequest : AmazonStepFunctionsRequest
    {
        private string _input;
        private string _name;
        private string _stateMachineArn;
        private string _traceHeader;

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
        /// Optional name of the execution. This name must be unique for your Amazon Web Services
        /// account, Region, and state machine for 90 days. For more information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html#service-limits-state-machine-executions">
        /// Limits Related to State Machine Executions</a> in the <i>Step Functions Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide a name for the execution, Step Functions automatically generates
        /// a universally unique identifier (UUID) as the execution name.
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
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine to execute.
        /// </para>
        ///  
        /// <para>
        /// The <c>stateMachineArn</c> parameter accepts one of the following inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>An unqualified state machine ARN</b> – Refers to a state machine ARN that isn't
        /// qualified with a version or alias ARN. The following is an example of an unqualified
        /// state machine ARN.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Step Functions doesn't associate state machine executions that you start with an unqualified
        /// ARN with a version. This is true even if that version uses the same revision that
        /// the execution used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A state machine version ARN</b> – Refers to a version ARN, which is a combination
        /// of state machine ARN and the version number separated by a colon (:). The following
        /// is an example of the ARN for version 10. 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;:10</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Step Functions doesn't associate executions that you start with a version ARN with
        /// any aliases that point to that version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A state machine alias ARN</b> – Refers to an alias ARN, which is a combination
        /// of state machine ARN and the alias name separated by a colon (:). The following is
        /// an example of the ARN for an alias named <c>PROD</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Step Functions associates executions that you start with an alias ARN with that alias
        /// and the state machine version used for that execution.
        /// </para>
        ///  </li> </ul>
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