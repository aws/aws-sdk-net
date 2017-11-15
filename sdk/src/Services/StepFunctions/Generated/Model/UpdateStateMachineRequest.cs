/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStateMachine operation.
    /// Updates an existing state machine by modifying its <code>definition</code> and/or
    /// <code>roleArn</code>. Running executions will continue to use the previous <code>definition</code>
    /// and <code>roleArn</code>.
    /// 
    ///  <note> 
    /// <para>
    /// All <code>StartExecution</code> calls within a few seconds will use the updated <code>definition</code>
    /// and <code>roleArn</code>. Executions started immediately after calling <code>UpdateStateMachine</code>
    /// may use the previous state machine <code>definition</code> and <code>roleArn</code>.
    /// You must include at least one of <code>definition</code> or <code>roleArn</code> or
    /// you will receive a <code>MissingRequiredParameter</code> error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateStateMachineRequest : AmazonStepFunctionsRequest
    {
        private string _definition;
        private string _roleArn;
        private string _stateMachineArn;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Amazon States Language definition of the state machine.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role of the state machine.
        /// </para>
        /// </summary>
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

    }
}