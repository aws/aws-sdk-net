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
    /// Container for the parameters to the CreateStateMachineAlias operation.
    /// Creates an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
    /// for a state machine that points to one or two <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
    /// of the same state machine. You can set your application to call <a>StartExecution</a>
    /// with an alias and update the version the alias uses without changing the client's
    /// code.
    /// 
    ///  
    /// <para>
    /// You can also map an alias to split <a>StartExecution</a> requests between two versions
    /// of a state machine. To do this, add a second <c>RoutingConfig</c> object in the <c>routingConfiguration</c>
    /// parameter. You must also specify the percentage of execution run requests each version
    /// should receive in both <c>RoutingConfig</c> objects. Step Functions randomly chooses
    /// which version runs a given execution based on the percentage you specify.
    /// </para>
    ///  
    /// <para>
    /// To create an alias that points to a single version, specify a single <c>RoutingConfig</c>
    /// object with a <c>weight</c> set to 100.
    /// </para>
    ///  
    /// <para>
    /// You can create up to 100 aliases for each state machine. You must delete unused aliases
    /// using the <a>DeleteStateMachineAlias</a> API action.
    /// </para>
    ///  
    /// <para>
    ///  <c>CreateStateMachineAlias</c> is an idempotent API. Step Functions bases the idempotency
    /// check on the <c>stateMachineArn</c>, <c>description</c>, <c>name</c>, and <c>routingConfiguration</c>
    /// parameters. Requests that contain the same values for these parameters return a successful
    /// idempotent response without creating a duplicate resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStateMachineAlias</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateStateMachineAliasRequest : AmazonStepFunctionsRequest
    {
        private string _description;
        private string _name;
        private List<RoutingConfigurationListItem> _routingConfiguration = AWSConfigs.InitializeCollections ? new List<RoutingConfigurationListItem>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the state machine alias.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state machine alias.
        /// </para>
        ///  
        /// <para>
        /// To avoid conflict with version ARNs, don't use an integer in the name of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// The routing configuration of a state machine alias. The routing configuration shifts
        /// execution traffic between two state machine versions. <c>routingConfiguration</c>
        /// contains an array of <c>RoutingConfig</c> objects that specify up to two state machine
        /// versions. Step Functions then randomly choses which version to run an execution with
        /// based on the weight assigned to each <c>RoutingConfig</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<RoutingConfigurationListItem> RoutingConfiguration
        {
            get { return this._routingConfiguration; }
            set { this._routingConfiguration = value; }
        }

        // Check to see if RoutingConfiguration property is set
        internal bool IsSetRoutingConfiguration()
        {
            return this._routingConfiguration != null && (this._routingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}