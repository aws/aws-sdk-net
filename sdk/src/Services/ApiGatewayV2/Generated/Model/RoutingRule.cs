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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents a routing rule.
    /// </summary>
    public partial class RoutingRule
    {
        private List<RoutingRuleAction> _actions = AWSConfigs.InitializeCollections ? new List<RoutingRuleAction>() : null;
        private List<RoutingRuleCondition> _conditions = AWSConfigs.InitializeCollections ? new List<RoutingRuleCondition>() : null;
        private int? _priority;
        private string _routingRuleArn;
        private string _routingRuleId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The routing rule action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingRuleAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The routing rule condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingRuleCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The routing rule priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoutingRuleArn. 
        /// <para>
        /// The routing rule ARN.
        /// </para>
        /// </summary>
        public string RoutingRuleArn
        {
            get { return this._routingRuleArn; }
            set { this._routingRuleArn = value; }
        }

        // Check to see if RoutingRuleArn property is set
        internal bool IsSetRoutingRuleArn()
        {
            return this._routingRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingRuleId. 
        /// <para>
        /// The routing rule ID.
        /// </para>
        /// </summary>
        public string RoutingRuleId
        {
            get { return this._routingRuleId; }
            set { this._routingRuleId = value; }
        }

        // Check to see if RoutingRuleId property is set
        internal bool IsSetRoutingRuleId()
        {
            return this._routingRuleId != null;
        }

    }
}