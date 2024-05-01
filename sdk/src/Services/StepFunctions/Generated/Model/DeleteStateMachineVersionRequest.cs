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
    /// Container for the parameters to the DeleteStateMachineVersion operation.
    /// Deletes a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>.
    /// After you delete a version, you can't call <a>StartExecution</a> using that version's
    /// ARN or use the version with a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Deleting a state machine version won't terminate its in-progress executions.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// You can't delete a state machine version currently referenced by one or more aliases.
    /// Before you delete a version, you must either delete the aliases or update them to
    /// point to another state machine version.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PublishStateMachineVersion</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStateMachineVersions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteStateMachineVersionRequest : AmazonStepFunctionsRequest
    {
        private string _stateMachineVersionArn;

        /// <summary>
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine version to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string StateMachineVersionArn
        {
            get { return this._stateMachineVersionArn; }
            set { this._stateMachineVersionArn = value; }
        }

        // Check to see if StateMachineVersionArn property is set
        internal bool IsSetStateMachineVersionArn()
        {
            return this._stateMachineVersionArn != null;
        }

    }
}