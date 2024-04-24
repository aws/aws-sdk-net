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
    /// Container for the parameters to the DeleteStateMachineAlias operation.
    /// Deletes a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
    /// 
    ///  
    /// <para>
    /// After you delete a state machine alias, you can't use it to start executions. When
    /// you delete a state machine alias, Step Functions doesn't delete the state machine
    /// versions that alias references.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateStateMachineAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeStateMachineAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStateMachineAliases</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateStateMachineAlias</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteStateMachineAliasRequest : AmazonStepFunctionsRequest
    {
        private string _stateMachineAliasArn;

        /// <summary>
        /// Gets and sets the property StateMachineAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine alias to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StateMachineAliasArn
        {
            get { return this._stateMachineAliasArn; }
            set { this._stateMachineAliasArn = value; }
        }

        // Check to see if StateMachineAliasArn property is set
        internal bool IsSetStateMachineAliasArn()
        {
            return this._stateMachineAliasArn != null;
        }

    }
}