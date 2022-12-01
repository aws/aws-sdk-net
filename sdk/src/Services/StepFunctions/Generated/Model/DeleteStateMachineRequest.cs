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
    /// Container for the parameters to the DeleteStateMachine operation.
    /// Deletes a state machine. This is an asynchronous operation: It sets the state machine's
    /// status to <code>DELETING</code> and begins the deletion process. 
    /// 
    ///  
    /// <para>
    /// If the given state machine Amazon Resource Name (ARN) is a qualified state machine
    /// ARN, it will fail with ValidationException.
    /// </para>
    ///  
    /// <para>
    /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
    /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
    /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
    /// the state machine named <code>stateMachineName</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// For <code>EXPRESS</code> state machines, the deletion will happen eventually (usually
    /// less than a minute). Running executions may emit logs after <code>DeleteStateMachine</code>
    /// API is called.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteStateMachineRequest : AmazonStepFunctionsRequest
    {
        private string _stateMachineArn;

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine to delete.
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

    }
}