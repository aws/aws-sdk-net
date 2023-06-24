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
    /// Container for the parameters to the UpdateStateMachineAlias operation.
    /// Updates the configuration of an existing state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
    /// by modifying its <code>description</code> or <code>routingConfiguration</code>.
    /// 
    ///  
    /// <para>
    /// You must specify at least one of the <code>description</code> or <code>routingConfiguration</code>
    /// parameters to update a state machine alias.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>UpdateStateMachineAlias</code> is an idempotent API. Step Functions bases the
    /// idempotency check on the <code>stateMachineAliasArn</code>, <code>description</code>,
    /// and <code>routingConfiguration</code> parameters. Requests with the same parameters
    /// return an idempotent response.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// This operation is eventually consistent. All <a>StartExecution</a> requests made within
    /// a few seconds use the latest alias configuration. Executions started immediately after
    /// calling <code>UpdateStateMachineAlias</code> may use the previous routing configuration.
    /// </para>
    ///  </note> 
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
    ///  <a>DeleteStateMachineAlias</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateStateMachineAliasRequest : AmazonStepFunctionsRequest
    {
        private string _description;
        private List<RoutingConfigurationListItem> _routingConfiguration = new List<RoutingConfigurationListItem>();
        private string _stateMachineAliasArn;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the state machine alias.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// The routing configuration of the state machine alias.
        /// </para>
        ///  
        /// <para>
        /// An array of <code>RoutingConfig</code> objects that specifies up to two state machine
        /// versions that the alias starts executions for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<RoutingConfigurationListItem> RoutingConfiguration
        {
            get { return this._routingConfiguration; }
            set { this._routingConfiguration = value; }
        }

        // Check to see if RoutingConfiguration property is set
        internal bool IsSetRoutingConfiguration()
        {
            return this._routingConfiguration != null && this._routingConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StateMachineAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine alias.
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