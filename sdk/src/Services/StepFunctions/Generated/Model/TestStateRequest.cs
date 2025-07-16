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
    /// Container for the parameters to the TestState operation.
    /// Accepts the definition of a single state and executes it. You can test a state without
    /// creating a state machine or updating an existing state machine. Using this API, you
    /// can test the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A state's <a href="https://docs.aws.amazon.com/step-functions/latest/dg/test-state-isolation.html#test-state-input-output-dataflow">input
    /// and output processing</a> data flow
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-services.html">Amazon
    /// Web Services service integration</a> request and response
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <a href="https://docs.aws.amazon.com/step-functions/latest/dg/call-https-apis.html">HTTP
    /// Task</a> request and response
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can call this API on only one state at a time. The states that you can test include
    /// the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-task-state.html#task-types">All
    /// Task types</a> except <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-activities.html">Activity</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-pass-state.html">Pass</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-wait-state.html">Wait</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-choice-state.html">Choice</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-succeed-state.html">Succeed</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-fail-state.html">Fail</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The <c>TestState</c> API assumes an IAM role which must contain the required IAM permissions
    /// for the resources your state is accessing. For information about the permissions a
    /// state might need, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/test-state-isolation.html#test-state-permissions">IAM
    /// permissions to test a state</a>.
    /// </para>
    ///  
    /// <para>
    /// The <c>TestState</c> API can run for up to five minutes. If the execution of a state
    /// exceeds this duration, it fails with the <c>States.Timeout</c> error.
    /// </para>
    ///  
    /// <para>
    ///  <c>TestState</c> doesn't support <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-activities.html">Activity
    /// tasks</a>, <c>.sync</c> or <c>.waitForTaskToken</c> <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html">service
    /// integration patterns</a>, <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-parallel-state.html">Parallel</a>,
    /// or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-map-state.html">Map</a>
    /// states.
    /// </para>
    /// </summary>
    public partial class TestStateRequest : AmazonStepFunctionsRequest
    {
        private string _definition;
        private string _input;
        private InspectionLevel _inspectionLevel;
        private bool? _revealSecrets;
        private string _roleArn;
        private string _variables;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> (ASL) definition of the state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1048576)]
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
        /// Gets and sets the property Input. 
        /// <para>
        /// A string that contains the JSON input data for the state.
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
        /// Gets and sets the property InspectionLevel. 
        /// <para>
        /// Determines the values to return when a state is tested. You can specify one of the
        /// following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INFO</c>: Shows the final state output. By default, Step Functions sets <c>inspectionLevel</c>
        /// to <c>INFO</c> if you don't specify a level.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEBUG</c>: Shows the final state output along with the input and output data processing
        /// result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRACE</c>: Shows the HTTP request and response for an HTTP Task. This level also
        /// shows the final state output along with the input and output data processing result.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each of these levels also provide information about the status of the state execution
        /// and the next state to transition to.
        /// </para>
        /// </summary>
        public InspectionLevel InspectionLevel
        {
            get { return this._inspectionLevel; }
            set { this._inspectionLevel = value; }
        }

        // Check to see if InspectionLevel property is set
        internal bool IsSetInspectionLevel()
        {
            return this._inspectionLevel != null;
        }

        /// <summary>
        /// Gets and sets the property RevealSecrets. 
        /// <para>
        /// Specifies whether or not to include secret information in the test result. For HTTP
        /// Tasks, a secret includes the data that an EventBridge connection adds to modify the
        /// HTTP request headers, query parameters, and body. Step Functions doesn't omit any
        /// information included in the state definition or the HTTP response.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>revealSecrets</c> to <c>true</c>, you must make sure that the IAM user
        /// that calls the <c>TestState</c> API has permission for the <c>states:RevealSecrets</c>
        /// action. For an example of IAM policy that sets the <c>states:RevealSecrets</c> permission,
        /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/test-state-isolation.html#test-state-permissions">IAM
        /// permissions to test a state</a>. Without this permission, Step Functions throws an
        /// access denied error.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>revealSecrets</c> is set to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? RevealSecrets
        {
            get { return this._revealSecrets; }
            set { this._revealSecrets = value; }
        }

        // Check to see if RevealSecrets property is set
        internal bool IsSetRevealSecrets()
        {
            return this._revealSecrets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role with the required IAM permissions
        /// for the state.
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
        /// Gets and sets the property Variables. 
        /// <para>
        /// JSON object literal that sets variables used in the state under test. Object keys
        /// are the variable names and values are the variable values.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null;
        }

    }
}