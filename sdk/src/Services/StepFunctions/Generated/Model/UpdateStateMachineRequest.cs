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
    /// Container for the parameters to the UpdateStateMachine operation.
    /// Updates an existing state machine by modifying its <code>definition</code>, <code>roleArn</code>,
    /// or <code>loggingConfiguration</code>. Running executions will continue to use the
    /// previous <code>definition</code> and <code>roleArn</code>. You must include at least
    /// one of <code>definition</code> or <code>roleArn</code> or you will receive a <code>MissingRequiredParameter</code>
    /// error.
    /// 
    ///  
    /// <para>
    /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
    /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
    /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
    /// the state machine named <code>stateMachineName</code>.
    /// </para>
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
    /// After you update your state machine, you can set the <code>publish</code> parameter
    /// to <code>true</code> in the same action to publish a new <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>.
    /// This way, you can opt-in to strict versioning of your state machine.
    /// </para>
    ///  <note> 
    /// <para>
    /// Step Functions assigns monotonically increasing integers for state machine versions,
    /// starting at version number 1.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// All <code>StartExecution</code> calls within a few seconds use the updated <code>definition</code>
    /// and <code>roleArn</code>. Executions started immediately after you call <code>UpdateStateMachine</code>
    /// may use the previous state machine <code>definition</code> and <code>roleArn</code>.
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateStateMachineRequest : AmazonStepFunctionsRequest
    {
        private string _definition;
        private LoggingConfiguration _loggingConfiguration;
        private bool? _publish;
        private string _roleArn;
        private string _stateMachineArn;
        private TracingConfiguration _tracingConfiguration;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Amazon States Language definition of the state machine. See <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1048576)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// Use the <code>LoggingConfiguration</code> data type to set CloudWatch Logs options.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// Specifies whether the state machine version is published. The default is <code>false</code>.
        /// To publish a version after updating the state machine, set <code>publish</code> to
        /// <code>true</code>.
        /// </para>
        /// </summary>
        public bool Publish
        {
            get { return this._publish.GetValueOrDefault(); }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role of the state machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine.
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
        /// Gets and sets the property TracingConfiguration. 
        /// <para>
        /// Selects whether X-Ray tracing is enabled.
        /// </para>
        /// </summary>
        public TracingConfiguration TracingConfiguration
        {
            get { return this._tracingConfiguration; }
            set { this._tracingConfiguration = value; }
        }

        // Check to see if TracingConfiguration property is set
        internal bool IsSetTracingConfiguration()
        {
            return this._tracingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// An optional description of the state machine version to publish.
        /// </para>
        ///  
        /// <para>
        /// You can only specify the <code>versionDescription</code> parameter if you've set <code>publish</code>
        /// to <code>true</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}