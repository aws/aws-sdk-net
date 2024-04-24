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
    /// Starts execution of a Step Functions state machine.
    /// </summary>
    public partial class StepFunctionsAction
    {
        private string _executionNamePrefix;
        private string _roleArn;
        private string _stateMachineName;

        /// <summary>
        /// Gets and sets the property ExecutionNamePrefix. 
        /// <para>
        /// (Optional) A name will be given to the state machine execution consisting of this
        /// prefix followed by a UUID. Step Functions automatically creates a unique name for
        /// each state machine execution if one is not provided.
        /// </para>
        /// </summary>
        public string ExecutionNamePrefix
        {
            get { return this._executionNamePrefix; }
            set { this._executionNamePrefix = value; }
        }

        // Check to see if ExecutionNamePrefix property is set
        internal bool IsSetExecutionNamePrefix()
        {
            return this._executionNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants IoT permission to start execution of a state machine
        /// ("Action":"states:StartExecution").
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StateMachineName. 
        /// <para>
        /// The name of the Step Functions state machine whose execution will be started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StateMachineName
        {
            get { return this._stateMachineName; }
            set { this._stateMachineName = value; }
        }

        // Check to see if StateMachineName property is set
        internal bool IsSetStateMachineName()
        {
            return this._stateMachineName != null;
        }

    }
}