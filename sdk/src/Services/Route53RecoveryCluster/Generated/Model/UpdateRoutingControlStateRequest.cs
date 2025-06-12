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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryCluster.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoutingControlState operation.
    /// Set the state of the routing control to reroute traffic. You can set the value to
    /// ON or OFF. When the state is ON, traffic flows to a cell. When the state is OFF, traffic
    /// does not flow.
    /// 
    ///  
    /// <para>
    /// With Route 53 ARC, you can add safety rules for routing controls, which are safeguards
    /// for routing control state updates that help prevent unexpected outcomes, like fail
    /// open traffic routing. However, there are scenarios when you might want to bypass the
    /// routing control safeguards that are enforced with safety rules that you've configured.
    /// For example, you might want to fail over quickly for disaster recovery, and one or
    /// more safety rules might be unexpectedly preventing you from updating a routing control
    /// state to reroute traffic. In a "break glass" scenario like this, you can override
    /// one or more safety rules to change a routing control state and fail over your application.
    /// </para>
    ///  
    /// <para>
    /// The <c>SafetyRulesToOverride</c> property enables you override one or more safety
    /// rules and update routing control states. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
    /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
    /// Controller Developer Guide.
    /// </para>
    ///  
    /// <para>
    ///  <i>You must specify Regional endpoints when you work with API cluster operations
    /// to get or update routing control states in Route 53 ARC.</i> 
    /// </para>
    ///  
    /// <para>
    /// To see a code example for getting a routing control state, including accessing Regional
    /// cluster endpoints in sequence, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/service_code_examples_actions.html">API
    /// examples</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.update.html">
    /// Viewing and updating routing control states</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.html">Working
    /// with routing controls overall</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateRoutingControlStateRequest : AmazonRoute53RecoveryClusterRequest
    {
        private string _routingControlArn;
        private RoutingControlState _routingControlState;
        private List<string> _safetyRulesToOverride = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the routing control that you want to update the
        /// state for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RoutingControlArn
        {
            get { return this._routingControlArn; }
            set { this._routingControlArn = value; }
        }

        // Check to see if RoutingControlArn property is set
        internal bool IsSetRoutingControlArn()
        {
            return this._routingControlArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingControlState. 
        /// <para>
        /// The state of the routing control. You can set the value to ON or OFF.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingControlState RoutingControlState
        {
            get { return this._routingControlState; }
            set { this._routingControlState = value; }
        }

        // Check to see if RoutingControlState property is set
        internal bool IsSetRoutingControlState()
        {
            return this._routingControlState != null;
        }

        /// <summary>
        /// Gets and sets the property SafetyRulesToOverride. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the safety rules that you want to override when
        /// you're updating the state of a routing control. You can override one safety rule or
        /// multiple safety rules by including one or more ARNs, separated by commas.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.override-safety-rule.html">
        /// Override safety rules to reroute traffic</a> in the Amazon Route 53 Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SafetyRulesToOverride
        {
            get { return this._safetyRulesToOverride; }
            set { this._safetyRulesToOverride = value; }
        }

        // Check to see if SafetyRulesToOverride property is set
        internal bool IsSetSafetyRulesToOverride()
        {
            return this._safetyRulesToOverride != null && (this._safetyRulesToOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}