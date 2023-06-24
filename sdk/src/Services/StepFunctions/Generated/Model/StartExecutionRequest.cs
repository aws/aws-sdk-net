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
    /// with a label <code>mapStateLabel</code> in a state machine named <code>myStateMachine</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</code>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
    /// the request fails with <code>ValidationException</code>.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The following qualified state machine ARN refers to an alias named <code>PROD</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</code>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
    /// ARN, the request starts execution for that version or alias.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The following unqualified state machine ARN refers to a state machine named <code>myStateMachine</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</code>
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
    /// call <code>StartExecution</code> and provide the version ARN or the ARN of an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
    /// that points to the version.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>StartExecution</code> is idempotent for <code>STANDARD</code> workflows. For
    /// a <code>STANDARD</code> workflow, if you call <code>StartExecution</code> with the
    /// same name and input as a running execution, the call succeeds and return the same
    /// response as the original request. If the execution is closed or if the input is different,
    /// it returns a <code>400 ExecutionAlreadyExists</code> error. You can reuse names after
    /// 90 days. 
    /// </para>
    ///  
    /// <para>
    ///  <code>StartExecution</code> isn't idempotent for <code>EXPRESS</code> workflows.
    /// 
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
        ///  <code>"input": "{\"first_name\" : \"test\"}"</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't include any JSON input data, you still must include the two braces, for
        /// example: <code>"input": "{}"</code> 
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
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// white space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <code>&lt; &gt; { } [ ]</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <code>? *</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <code>" # % \ ^ | ~ ` $ &amp; , ; : /</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<code>U+0000-001F</code>, <code>U+007F-009F</code>)
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
        /// The <code>stateMachineArn</code> parameter accepts one of the following inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>An unqualified state machine ARN</b> – Refers to a state machine ARN that isn't
        /// qualified with a version or alias ARN. The following is an example of an unqualified
        /// state machine ARN.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</code>
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
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;:10</code>
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
        /// an example of the ARN for an alias named <code>PROD</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</code>
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