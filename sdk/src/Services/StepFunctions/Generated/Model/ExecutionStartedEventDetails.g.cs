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
    /// Contains details about the start of the execution.
    /// </summary>
    public partial class ExecutionStartedEventDetails
    {
        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The JSON data input to the execution. Length constraints apply to the payload size,
        /// and are expressed as bytes in UTF-8 encoding.
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
        /// <para>
        /// Contains details about the input for an execution history event.
        /// </para>
        /// </summary>
        public HistoryEventExecutionDataDetails InputDetails { get; set; }

        /// <summary>
        /// Checks to see if the InputDetails property is set.
        /// </summary>
        internal bool IsSetInputDetails() => this.InputDetails != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used for executing Lambda tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StateMachineAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies a state machine alias used for starting
        /// the state machine execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StateMachineAliasArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineAliasArn property is set.
        /// </summary>
        internal bool IsSetStateMachineAliasArn() => this.StateMachineAliasArn != null;

        /// <summary>
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies a state machine version used for starting
        /// the state machine execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StateMachineVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineVersionArn property is set.
        /// </summary>
        internal bool IsSetStateMachineVersionArn() => this.StateMachineVersionArn != null;
    }
}
